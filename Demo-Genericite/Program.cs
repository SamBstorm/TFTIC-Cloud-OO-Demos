namespace Demo_Genericite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList list = new IntList();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            LongList list2 = new LongList();
            list2.Add(10_000_000_000);
            list2.Add(20_000_000_000);
            list2.Add(30_000_000_000);
            list2.Add(40_000_000_000);

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            ListGeneric<string> listGeneric = new ListGeneric<string>();
            listGeneric.Add("Hello");
            listGeneric.Add("Bonjour");
            listGeneric.Add("Goeiedag");
            listGeneric.Add("Aloha");

            for (int i = 0; i < listGeneric.Count; i++)
            {
                Console.WriteLine(listGeneric[i]);
            }

            DictionaryGeneric<string,int> dico = new DictionaryGeneric<string,int>();

            dico.Add("un", 1);
            dico.Add("deux", 2);
            dico.Add("trois", 3);
            dico.Add("quatre", 4);
            dico.Add("quatre", 4);
            dico.Add("cinq", 5);

            for (int i = 0; i < dico.Keys.Count; i++)
            {
                string key = dico.Keys[i];
                Console.WriteLine($"{key} : {dico[key]}");
            }
        }
    }
}
