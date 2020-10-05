using System;
class CircularList
    {
        public Node head { get; set; }
        public int counter { get; set; }


        public CircularList() {
            head = null;
            this.counter = 0;
        }

        public void Printar()
        {
            if(head == null) return;
            Node aux = head;
            do {
                Console.WriteLine(aux.data);
                aux = aux.next;
            } while(aux != head);
        }

        public void Add(Contato contato)
        {
            Node newNode = new Node(contato);

            if(head == null)
            {
                newNode.next = newNode.temp = newNode;
                head = newNode;
            }
            else
            {
                Node ultimo = head.temp;
                newNode.next = head;
                head.temp = newNode;
                newNode.temp = ultimo;
                ultimo.next = newNode;
            }

            this.counter++;
        }

        public bool Deletar(string email)
        {
            if(head == null) return false;

            Node aux = head;
            Node temp = null;

            while(aux.data.Email != email)
            {
                if(aux.next == head) return false;

                temp = aux;
                aux = aux.next;
            }

            if(aux.next == head && temp == null)
            {
                head = null;
                this.counter--;
                return true;
            }

            if(aux == head)
            {
                temp = head.temp;
                head = head.next;

                temp.next = head;
                head.next = temp;
            }
            else if(aux.next == head)
            {
                temp.next = head;
                head.temp = temp;
            }
            else
            {
                Node newNode = aux.next;

                temp.next = newNode;
                newNode.temp = temp;
            }
            aux = null;
            this.counter--;
            return true;
        }

        public Contato Encontrar(string email)
        {
            if(head == null) return null;
            Node aux = head;
            do {
                if(aux.data.Email == email) return aux.data;
                aux = aux.next;
            } while(aux != head);

            return null;
        }

        public void Ordenar()
        {
            bool aux;
            Node temp;
            int length = counter;

            if(length <= 0)
            {
                Console.WriteLine("Lista Vazia.");
                return;
            }

            do
            {
                aux = false;
                temp = head;
                for (int i = 0; i < length - 1; i++)
                {
                    string compItemPrev;
                    string compItemNext;
                    
                    compItemPrev = temp.data.Name;
                    compItemNext = temp.next.data.Name;                    

                    if (String.Compare(compItemPrev, compItemNext) > 0)
                    {
                        Contato c = temp.data;
                        temp.data = temp.next.data;
                        temp.next.data = c;
                        aux = true;
                    }
                    temp = temp.next;
                }
            } while (aux);
        }

        public void Trocar(Node a, Node b)
        {
            Node[] vetorAux = new Node[4];
            Node aux;

            if(b.next == a)
            {
                aux = a;
                a = b;
                b = aux;
            }

            vetorAux[0] = a.temp;
            vetorAux[1] = b.temp;
            vetorAux[2] = a.next;
            vetorAux[3] = b.next;

            if((a.next == b && b.next == a) || (a.next == b && b.next == a))
            {
                a.temp = vetorAux[2];
                b.temp = vetorAux[0];
                a.next = vetorAux[3];
                b.next = vetorAux[1];
            }
            else
            {
                a.temp = vetorAux[1];
                b.temp = vetorAux[0];
                a.next = vetorAux[3];
                b.next = vetorAux[2];
            }

            a.temp.next = a;
            a.next.temp = a;

            b.temp.next = b;
            b.next.temp = b;
        }

        public int Tamanho()
        {
            if(head == null) return 0;

            Node aux = head;
            int cont = 0;
            do {
                cont++;
                aux = aux.next;
            } while(aux != head);

            return cont;
        }

        public void Recuperar(String name){
        String comparar;
        if (head == null)
        {
            Console.Write("Lista Vazia.");
        }
        var aux = head;
        do
        {
            comparar = aux.data.Name;
            if(name.Equals(comparar)){
                Console.WriteLine("CONTATO PROCURADO: " + aux.data);
            }
            aux = aux.next;
        } while (aux != head);
    }
    }

  