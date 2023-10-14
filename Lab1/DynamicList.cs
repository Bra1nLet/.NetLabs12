using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
namespace Lab1; 
using System.Collections; 

public class DynamicList
{
    public ArrayList array = new ArrayList();

    private void validate(int a, int b)
    {
        if (a > b) throw new IndexOutOfRangeException("Cannot process this request");
    }
    public void place(int from, int to, object data)
    {
        validate(from, to);
        for (int i = from; i < to; i++)
        {
            if (from > array.Count)
            {
                array.Add(null);
                to++;
            }
            else if (i < array.Count) array[i] = data;
            
            else array.Add(data);
        }
    }
    
    public void pop(int from, int to)
    {        
        validate(from, to);
        for (int i = from; i < to; i++)
        {
            if (i >= array.Count) break;
            array.RemoveAt(i);
        }
    }

    public void print()
    {
        for (int i = 0; i < array.Count; i++)
        {
            System.Console.WriteLine("id: " + i + " " + array[i]);
        }
    }

    public ArrayList get(int from, int to)
    {
        validate(from, to);
        ArrayList _array = new ArrayList();
        if (from > array.Count || array.Count > to)
        {
            Console.WriteLine("Array don't have this elements!");
            return _array;
        }
        for (int i = from; i < to; i++)
        { 
            if (i >= array.Count) break;
            _array.Add(array[i]);
        }
        return _array;
    }
}