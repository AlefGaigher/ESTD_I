using System;
using System.Linq;

public class HashTable
{
    private int _tableSize;
    private Cell[] table;
    public HashTable(int tam)
    {
        _tableSize = tam;
        table = new Cell[tam];
    }
    public void Add(string word)
    {
        int index = HashFunction(word);
        while (table[index] != null && !table[index].Key.Equals(word))
        {
            index = (index + 1) % _tableSize;
        }
        if (table[index] == null)
        {
            table[index] = new Cell();
            table[index].Key = word;
        }
        table[index].Count++;
    }
    public void PrintReport()
    {
        var sorted = table.Where(c => c!= null).ToArray().
                            OrderBy(item => item.Count);
        foreach (var cell in sorted)
        {
            if(cell != null)
            {
                Console.WriteLine($"Word:{cell.Key} x {cell.Count}");
            }
        }
    }
    private int HashFunction(string word)
    {
        var caracteres = word.ToCharArray();
        var soma = 0;
        foreach (var c in caracteres)
        {
            soma += c;
        }
        return soma % _tableSize;
    }    
}

public class Cell
{
    public string Key { get; set; }
    public int Count { get; set; }
}