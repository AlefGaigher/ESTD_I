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

    public void PrintIrOrdem()
    {
        Console.Write("<");        
        if (SAE != null)
            SAE.PrintIrOrdem();
        else
            Console.Write("<>");

        Console.Write(data);

        if (SAD != null)
            SAD.PrintIrOrdem();
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

        if (SAE != null && SAE.Pertence(x))
            return true;

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
    
    //Altura de um valor especifico

    //Tipo da arvore
    
    //Contar nós

    //Contar folhas
}