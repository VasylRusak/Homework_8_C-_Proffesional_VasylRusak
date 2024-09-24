using System.Text;
using System.Xml.Serialization;

namespace Task_2_1
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
            Person person = new Person { FirstName = "John", LastName = "Doe", Age = 30 };

            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, person);
                string xml = writer.ToString();
                Console.WriteLine("Серіалізація за замовчуванням:\n" + xml);
            }
            using (FileStream fs = new FileStream("person.xml", FileMode.Create))
            {
                serializer.Serialize(fs, person);
            }

            Person2 person2 = new Person2 { FirstName = "John", LastName = "Doe", Age = 30 };

            XmlSerializer serializer2 = new XmlSerializer(typeof(Person2));
            using (StringWriter writer = new StringWriter())
            {
                serializer2.Serialize(writer, person2);
                string xml = writer.ToString();
                Console.WriteLine("Серіалізація з атрибутами:\n" + xml);
            }
            using (FileStream fs = new FileStream("person2.xml", FileMode.Create))
            {
                serializer2.Serialize(fs, person2);
            }
        }
    }
}
