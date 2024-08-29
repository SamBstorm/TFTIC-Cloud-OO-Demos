namespace Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> inventory = new List<Item>();

            Item cleDonjon = new QuestItem("Clé du donjon", "Cette clé rouillée permet d'ouvrir le donjon de Naheulbeuk.");

            Item potion = new HealItem("Potion", 20);
            Item superPotion = new HealItem("Super Potion", 50);
            Item hyperPotion = new HealItem("Hyper Potion", 200);

            Item casque = new EquipmentItem("Casque de la volonté", EquipementLocalisation.Head);
            Item buste = new EquipmentItem("Buste de la maladresse", EquipementLocalisation.Torso);
            Item epaulette = new EquipmentItem("Epaulette de la carrure", EquipementLocalisation.Arms);
            Item basket = new EquipmentItem("Nike Air supra Jordan", EquipementLocalisation.Legs);

            inventory.Add(cleDonjon);
            inventory.Add(potion);
            inventory.Add(superPotion);
            inventory.Add(hyperPotion);
            inventory.Add(casque);
            inventory.Add(buste);
            inventory.Add(epaulette);
            inventory.Add(basket);

            while (inventory.Count > 0)
            {
                Console.WriteLine("Quel objet manipuler ?");
                int count = 1;
                foreach (Item item in inventory)
                {
                    Console.WriteLine($"{count} - {item.Name}");
                    count++;
                }
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Que voulez-vous faire ?");
                Console.Write("[U]tiliser");

                if (inventory[choice-1] is IDroppable)
                {
                    Console.Write(" - [J]eter");
                }
                Console.WriteLine();
                string action = Console.ReadLine();
                if (action.ToUpper() == "U")
                {
                    inventory[choice - 1].Use();
                    if (inventory[choice - 1] is IOneUse)
                    {
                        inventory.Remove(inventory[choice - 1]);
                    }
                }
                else if (action.ToUpper() == "J" && inventory[choice - 1] is IDroppable) {
                    inventory.Remove(inventory[choice - 1]);
                }
            }
        }
    }
}
