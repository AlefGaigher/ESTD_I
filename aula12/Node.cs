using System;

public class Node
{
    public int data;
    public Node SAE;
    public Node SAD;
    //Folha
    public Node(int value)
    {
        data = value;
        SAE = null;
        SAD = null;
    }
    //Nó Intermediario
    public Node(int value, Node esq, Node dir)
    {
        data = value;
        SAE = esq;
        SAD = dir;
    }

    public void Add(int v)
    {
        if (v < data)
        {
            if (SAE == null)
                SAE = new Node(v);
            else
                SAE.Add(v);
        }
        else
        {
            if (SAD == null)
                SAD = new Node(v);
            else
                SAD.Add(v);
        }
    }

    public Node Remove(int v)
    {
         if (data == v)
        {//eu sou o no a ser removido
         //1) o no é folha
            if (SAE == null && SAD == null)
            {
                return null;
            }
            //2) o no possui 1 filho
            if (SAE == null)
            {//só tenho filho a direita
                return SAD;
            }
            if (SAD == null)
            {//só tenho o filho a esquerda
                return SAE;
            }
            //3) o no tem dois filhos
            Node herdeiro = SAE;
            while (herdeiro.SAD != null)
            { 
                herdeiro = SAD; 
            }
            int tempData = herdeiro.data;
            this.Remove(herdeiro.data);
            data = tempData;
            return this;
        }
        else
        {//eu não sou o no a ser removido
            if (v < data && SAE != null)
            {//vai remover a minha esquerda
                SAE = SAE.Remove(v);
            }
            else if (v > data && SAD != null)
            {//vai remover a minha direita
                SAD = SAD.Remove(v);
            }
            return this;
        }        
    }

    public void PrintPreOrdem()
    {
        Console.Write("<");
        Console.Write(data);
        if (SAE != null)
            SAE.PrintPreOrdem();
        else
            Console.Write("<>");

        if (SAD != null)
            SAD.PrintPreOrdem();
        else
            Console.Write("<>");

        Console.Write(">");
    }

    public void PrintInOrder()
    {
        Console.Write("<");
        if (SAE != null)
            SAE.PrintInOrder();
        else
            Console.Write("<>");

        Console.Write(data);

        if (SAD != null)
            SAD.PrintInOrder();
        else
            Console.Write("<>");

        Console.Write(">");
    }

    public void PrintPosOrdem()
    {
        Console.Write("<");
        if (SAE != null)
            SAE.PrintPosOrdem();
        else
            Console.Write("<>");

        if (SAD != null)
            SAD.PrintPosOrdem();
        else
            Console.Write("<>");

        Console.Write(data);

        Console.Write(">");
    }

    public bool Pertence(int x)
    {
        if (data == x)
            return true;

        if (x < data)
            if (SAE != null && SAE.Pertence(x))
                return true;
            else
            if (SAD != null && SAD.Pertence(x))
                return true;

        return false;
    }

    public int Altura()
    {
        int he = -1;
        int hd = -1;

        if (SAE == null && SAD == null)
            return 0;

        if (SAE != null)
            he = SAE.Altura();
        if (SAD != null)
            hd = SAD.Altura();

        return 1 + Math.Max(he, hd);
    }

    public int Count()
    {
        int ce = 0;
        int cd = 0;

        if (SAE == null && SAD == null)
            return 1;

        if (SAE != null)
            ce = SAE.Count();
        if (SAD != null)
            cd = SAD.Count();

        return 1 + ce + cd;
    }

}