using System;
public class Fila
{
    public Node filaInicio;
    public Node filaFim;
    public int contador = 0;

    public Fila()
    {
        filaInicio = null;
        filaFim = null;
    }
    public void Insert(Pessoa pessoa)
    {
        //Insere na fila
        Node novo = new Node(pessoa);
        if(IsEmpity())
        {
            filaInicio = novo;
            filaFim = novo;
        }
        else
        {
            filaFim.next = novo;
            filaFim = novo;
        }
        contador++;
    }
    public Pessoa Remove()
    {
        //Remove da fila
        Pessoa p = null;
        if(filaInicio == filaFim)
        {//Fila com um elemento
            p = filaInicio.data;
            filaInicio = null;
            filaFim = null;
            contador--;
        }
        else if(!IsEmpity())
        {//Cado normal (varios elementos)
            p = filaInicio.data;
            filaInicio = filaInicio.next;
            contador--;
        }
        
        return p; 
    }
    public bool IsEmpity()
    {
        //A fila é vazia?
        return filaInicio == null;
    }
    public void Clear()
    {
        //Esvaziar a fila
        while(!IsEmpity())
        {
            Remove();
        }
    }
    public int Count()
    {
        //Retorna quantos tem na fila;
        return contador;
    }
}
