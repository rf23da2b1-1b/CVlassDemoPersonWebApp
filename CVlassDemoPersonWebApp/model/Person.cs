namespace CVlassDemoPersonWebApp.model
{
    public class Person
    {

        // Instans felter
        private int _id;
        private string _name;
        private string _adr;

        // properties
        public int Id { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string Name { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Adr { 
            get { return _adr; } 
            set { _adr = value; }
        }


        // Konstruktører
        public Person()
        {
            _id = 0;
            _name = "";
            _adr = "";

        }
               
        public Person(int id, string name, string adr)
        {
            _id = id;
            _name = name;
            _adr = adr;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Adr)}={Adr}}}";
        }
    }
}
