namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            DynamicList dl = new DynamicList();
            dl.place(2, 20, 1);
            dl.place(7, 15, 5);
            dl.place(11, 13, 3);
            
            dl.array = dl.get(12, 20);
            dl.print();
        }        
    }

}
