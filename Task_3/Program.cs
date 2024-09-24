using System.Text;
using System.Xml.Serialization;

namespace Task_3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    [Serializable]
    public class Person2
    {
        [XmlAttribute]
        public string FirstName { get; set; }
        [XmlAttribute]
        public string LastName { get; set; }
        [XmlAttribute]
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            var path = @"D:\study\study_C#\C# proffesional\Homework\Homework_8_C#_Proffesional_VasylRusak\Homework_8_C#_Proffesional_VasylRusak\Task_2_1\bin\Debug\net8.0\";
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (FileStream fs = new FileStream(path+"person.xml", FileMode.Open))
            {
                Person person = (Person)serializer.Deserialize(fs);

                // Відображення стану об'єкта на екрані
                Console.WriteLine("Десеріалізований об'єкт:");
                Console.WriteLine($"FirstName: {person.FirstName}");
                Console.WriteLine($"LastName: {person.LastName}");
                Console.WriteLine($"Age: {person.Age}");
            }

            XmlSerializer serializer2 = new XmlSerializer(typeof(Person2));
            using (FileStream fs = new FileStream(path + "person2.xml", FileMode.Open))
            {
                Person2 person2 = (Person2)serializer2.Deserialize(fs);

                // Відображення стану об'єкта на екрані
                Console.WriteLine("Десеріалізований об'єкт:");
                Console.WriteLine($"FirstName: {person2.FirstName}");
                Console.WriteLine($"LastName: {person2.LastName}");
                Console.WriteLine($"Age: {person2.Age}");
            }
        }
    }
}
