using System;

namespace _14___HashCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hash!");
            //Tratamento do texto
            string texto =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut dictum felis at justo vehicula, in efficitur tellus consectetur. Ut porttitor lectus nulla, a malesuada lacus eleifend congue. Integer auctor nulla quam, sed tempor dui viverra vitae. Aenean a sem sem. Maecenas nec luctus nisi, mattis tincidunt velit. Donec faucibus risus ut dui pellentesque vestibulum. Proin in lacus mattis, finibus tellus ac, bibendum dui. Praesent dictum condimentum posuere. Fusce in lacus sit amet ipsum vestibulum tristique. Vivamus quis turpis vulputate, convallis sapien sit amet, pharetra justo. Quisque id quam nec tortor molestie varius congue eu lorem. Nulla et tempus justo. Ut laoreet sem mi, nec hendrerit sapien porttitor at. Mauris velit dui, ullamcorper id euismod id, posuere at velit. Nam hendrerit diam vitae libero facilisis tincidunt. Nullam eu nisl ante.Pellentesque quis ante in nunc tempus pulvinar.Nam non tellus molestie, scelerisque eros nec, aliquam ante. Maecenas nec tortor at nunc fringilla elementum.Nam ac lacus a enim tempus molestie et ut lectus. Etiam quis orci leo. Donec auctor massa eget ligula lobortis, at bibendum neque ultrices. Donec in enim scelerisque, aliquam augue laoreet, pellentesque risus. Quisque venenatis facilisis neque, vel posuere ipsum accumsan in. Pellentesque pretium at orci vitae ornare. Mauris eget ligula sit amet leo scelerisque tempor vel vel eros.Pellentesque ut placerat ex, vitae congue turpis.Nunc tempor lacus id finibus commodo. In convallis tellus sit amet lacinia facilisis.Aliquam sed sapien ipsum. Phasellus tincidunt justo lorem, posuere tempor nisi posuere nec.Nullam quis augue id ante placerat tempus ac eget odio. Maecenas quis fringilla mauris. Nunc condimentum est vel convallis sollicitudin. Curabitur tortor risus, vehicula eu tincidunt a, vulputate ac lorem.Aliquam dapibus libero id eros suscipit, ac viverra arcu laoreet. Aenean dictum quam magna, sed interdum eros finibus nec.Phasellus ullamcorper neque augue. Donec eget erat quis magna ullamcorper imperdiet nec ac nulla. Pellentesque at rutrum dui. Pellentesque quis ante id sapien ullamcorper auctor.In tempus ac tellus et sollicitudin. Duis eu tortor et ex mattis feugiat at ut turpis. Sed ultricies mollis lobortis. Quisque feugiat dui ut mauris interdum, vitae suscipit arcu iaculis. Quisque sed arcu nec odio sagittis commodo eget eget magna. Donec finibus facilisis felis vitae porta. Maecenas lorem tellus, placerat in lorem ac, volutpat faucibus orci.Sed in neque ullamcorper, sagittis sem venenatis, tincidunt felis. Sed pulvinar nisi sed risus pulvinar, id sagittis nibh vulputate. Aenean faucibus, sem porta iaculis hendrerit, lectus tortor sagittis sapien, nec pellentesque tellus urna bibendum diam. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Pellentesque nisi risus, mattis a erat a, elementum faucibus orci.Nulla in magna quis velit feugiat dignissim sit amet id risus.Maecenas tempor ligula justo, non condimentum ex sagittis non.In at orci imperdiet, rhoncus dui quis, cursus dui. Maecenas sit amet bibendum lorem, in euismod lectus. Fusce ac facilisis nunc, eu elementum libero.Proin consequat sit amet lacus sit amet mattis. Aenean mollis sit amet justo non volutpat.Fusce turpis nibh, vulputate eget nulla sed, condimentum posuere.";
            string textoTratado = texto.Replace(",", string.Empty);
            textoTratado = textoTratado.Replace(".", string.Empty);
            textoTratado = textoTratado.ToUpper();
            var palavras = textoTratado.Split(" ");
            //Inciar a Tabela
            HashTable hash = new HashTable(751);
            Console.WriteLine(palavras.Length);
            //Começar a contar
            foreach (var word in palavras)
            {
                hash.Add(word);
            }
            hash.PrintReport();
        }
    }
}