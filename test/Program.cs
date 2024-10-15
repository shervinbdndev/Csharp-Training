namespace Test
{
    class Person
    {
        public string? first_name
        {
            get; set;
        }
        public string? last_name
        {
            get; set;
        }
        public int? age
        {
            get; set;
        }

        public Person(string? first_name, string? last_name, int? age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }

        public string fullname()
        {
            return $"{this.first_name} {this.last_name}";
        }
    }

    class User : Person
    {
        public string? email
        {
            get; set;
        }

        public string? password
        {
            get; set;
        }
        public User(string? first_name, string? last_name, int? age, string? email, string? password) : base(first_name, last_name, age)
        {
            this.email = email;
            this.password = password;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("shervin", "badanara", 21, "shervin2234@gmail.com", "shb12345");
            System.Console.WriteLine(user.fullname());
            Console.ReadKey();
        }
    }
}

