using System;
using System.IO;
using System.Text;

namespace AgendaTel
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularList circlist = new CircularList();
            string op;
            do
            {
                Console.WriteLine("----{ Recovery Contact }----");
                Recovery(circlist);
                Console.WriteLine("----------{ Menu }----------");
                Console.WriteLine("Press key '1' to Add");
                Console.WriteLine("Press key '2' to Remover");
                Console.WriteLine("Press key '3' to Edit");
                Console.WriteLine("Press key '4' to List");
                Console.WriteLine("Press key '5' to Navigate");
                Console.WriteLine("Press key '0' to Exit");
                Console.WriteLine("----------------------------");

                op = Console.ReadKey().Key.ToString();
                Console.Clear();
                switch(op)
                {
                    case "D1":
                        Console.WriteLine("-----{ Add Contact }-----");
                        Add(circlist);
                        break;
                    case "D2":
                        Console.WriteLine("-----{ Remove Contact }-----");
                        Remove(circlist);
                        break;
                    case "D3":
                        Console.WriteLine("-----{ Edit Contact }-----");
                        Edit(circlist);
                        break;
                    case "D4":
                        Console.WriteLine("-----{ List Contact }-----");
                        List(circlist);
                        break;
                    case "D5":
                        Console.WriteLine("-----{ Walk Contact }-----");
                        Walk(circlist);
                        break;
                }
            } while(op != "D0");

            Console.WriteLine("END!");
        }

        public static void Add(CircularList circlist)
        {
            string name;
            string email;
            string telephone;

            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            email = Console.ReadLine();
            Console.WriteLine("Telephone: ");
            telephone = Console.ReadLine();

            circlist.Add(new Contato(name, email, telephone));
            Console.Clear();
            circlist.Ordenar();
            SaveFile(circlist);
            Console.WriteLine("Contact added successfully!");
        }

        public static void Remove(CircularList circlist)
        {
            List(circlist);
            string name;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            if(circlist.Deletar(name))
            {
                SaveFile(circlist);
                Console.WriteLine("Contact successfully deleted");
            }
            else
            {
                Console.WriteLine("Could not delete contact");
            }
        }

        public static void Edit(CircularList circlist)
        {
            List(circlist);
            string name;
            Console.WriteLine("Enter the Name of the contact you want to update: ");
            name = Console.ReadLine();
            Contato contato = circlist.Encontrar(name);
            if(contato == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                string newName;
                string newEmail;
                string newTelephone;

                Console.WriteLine("-----{ Editing Contact }-----");
                Console.WriteLine("To not modify the data, leave it blank.");

                Console.WriteLine($"Name({contato.Name}): ");
                newName = Console.ReadLine();
                if(!string.IsNullOrEmpty(newName))
                { 
                    contato.Name = newName;
                }

                Console.WriteLine($"E-mail({contato.Email}): ");
                newEmail = Console.ReadLine();
                if(!string.IsNullOrEmpty(newEmail))
                { 
                    contato.Email = newEmail;
                }

                Console.WriteLine($"Telephone({contato.Telephone}): ");
                newTelephone = Console.ReadLine();
                if(!string.IsNullOrEmpty(newTelephone))
                { 
                    contato.Telephone = newTelephone;
                }
                circlist.Ordenar();
                SaveFile(circlist);

                Console.WriteLine("Contact updated successfully.");
            }
        }

        public static void Recovery(CircularList circlist)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("Contatos.txt");
            
                int l = 0;

                while (l < lines.Length)
                { 
                    Contato contato = new Contato();

                    string[] aux = lines[l].Split("-");
                    contato.Name = aux[0];
                    contato.Telephone = aux[1]; 
                    contato.Email = aux[2];
                    circlist.Add(contato);
                l++;
                }
                //List(circlist);
            }
            catch(Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.ToString());
            }

            // try
            // {
            //     using (StreamReader file = new StreamReader("lista.txt"))
            //     {
            //         string name;
            //         string email;
            //         string telephone;
            //         while(true)
            //         {
            //             name = file.ReadLine();
            //             if(name == null) break;
            //             email = file.ReadLine();
            //             if(email == null) break;
            //             telephone = file.ReadLine();
            //             if(telephone == null) break;
            //             circlist.Add(new Contato(name, email, telephone));
            //         }
            //     }
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine(ex.ToString());
            // }
        }

        public static void List(CircularList circlist)
        {
            circlist.Printar();
            Console.WriteLine();
        }

        public static void SaveFile(CircularList circlist)
        {
            
            try
            {
                Node aux = circlist.head;

                if (aux != null)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter("Contatos.txt", false);
                    do{
                        file.WriteLine($"{aux.data.Name}-{aux.data.Email}-{aux.data.Telephone}");
                        aux = aux.next; 
                    }while (aux != circlist.head);
                    file.Close();
                } 
            else 
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("Contatos.txt", false);
                file.Close();
            }
                // using (FileStream fs = File.Create("Contatos.txt"))
                // {
                //     string[] linhas = File.ReadAllLines("Contatos.txt");
                //     Node aux = circlist.head;
                //     if(aux == null)
                //     {
                //      return;
                //     }
                //     while(aux.next != circlist.head) 
                //     {
                //         AddText(fs, $"{aux.data.Name}\n{aux.data.Email}\n{aux.data.Telephone}\n");                          
                //         aux = aux.next;
                //     }
                //     AddText(fs, $"{aux.data.Name}\n{aux.data.Email}\n{aux.data.Telephone}");
                // }
            }
            catch(Exception ex)
            {
                Console.WriteLine("deu ERROO");
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Walk(CircularList circlist)
        {
            Node aux = circlist.head;
            if(aux == null) 
            {
                return;
            }
            while(true)
            {
                Console.Clear();
                Console.WriteLine("-----{ Walk Contact }-----");
                Console.WriteLine("Left arrow: previous");
                Console.WriteLine("Right arrow: next");
                Console.WriteLine("Esc to Exit");
                Console.WriteLine("--------------------------");
                Console.WriteLine(aux.data);
                string key = Console.ReadKey().Key.ToString();
                if(key == "LeftArrow")
                {
                    aux = aux.temp;
                }
                else if(key == "RightArrow")
                {
                    aux = aux.next;
                }
                else if(key == "Escape")
                {
                    break;
                }
            }
            Console.Clear();
        }

        public static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}