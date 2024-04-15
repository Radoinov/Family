namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person a = new Person();
            //a.Age = -16;
            //a.Name = "Stanislav";
            

            //List<Person> Group2 = new List<Person>();
            //string prompt = "";
            //int index = 0;
            //while (prompt == "Yes")
            //{
            //    Person person = new Person();
                
            //    Console.Write($"Vavedi imeto na {index} 4ovek: ");
            //    person.Name = Console.ReadLine();
            //    Console.WriteLine($"Vavedi godinite na { index} 4ovek:");
            //    person.Age = int.Parse(Console.ReadLine());

            //    Group2.Add( person );

            //    Console.WriteLine("Iskash li oshte: ");
            //    prompt = Console.ReadLine();

            //}
            //foreach (Person person in Group2)
            //{
                
            //}

            //Create family
            Family myFamily = new Family();

            myFamily.FamilyName = "Radoinovi";
            Console.Write("Vyvedete broi 4lenove: ");
            int countMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countMembers; i++)
            {
                Console.Write($"Vyvedi {i + 1} 4ovek: ");
                Person currentPerson = new Person();
                Console.WriteLine("Vavedi ime: ");
                currentPerson.Name = Console.ReadLine();

                Console.WriteLine("Vavedi godini: ");
                currentPerson.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(currentPerson);
                
            }
            //Bubble sort Assending

            for (int i = 0;i < myFamily.Members.Count;i++)
            {
                for (int j = 0;j < myFamily.Members.Count -1;j++)
                {
                    if (myFamily.Members[j].Age >
                        myFamily.Members[j + 1].Age) 
                    { 
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }

                }
            }



            //ПЕЧАТ НА ЦЯЛОТО СЕМЕЙСТВО

            myFamily.PrintAllFamily();
        }
    }
}
