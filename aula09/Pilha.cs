using System;

public class Pilha
{
    private Node top;
    private int counter;
    //Construtor
    public Pilha()
    {
        //2do: Alocar a nossa pilha (TOP -> null)
        counter = 0;
        top = null;
    }
    //Inserir no topo da pilha
    public void Push(int valor)
    {
        Node novo =  new Node(valor);
        novo.next = top;
        top = novo;
        counter++;
    }
    //remove do topo e retorna o valor
    public int Pop()
    {
        if(Empity())
            return -1;
            
        Node aux = top;
        top = top.next;
        counter--;
        return aux.data;
    }
    //retorna quantos elementos tem na pilha
    public int Count()
    {
        return counter;
    }
    //retorna se a pilha e vazia
    public bool Empity()
    {
        return top == null;
    }
    //remove toda pilha
    public void Clear()
    {
        while(!Empity())
        {
            Pop();
        }
    }
    public int Peek() //top
    {
        if(Empity())
            return -1;
        
        return top.data;
    }      
}