internal class Node
{
    internal Contato data;
    public Node temp;
    public Node next;
    
    public Node(Contato contato)
    {
        data = contato;
        next = null;
    }
}
