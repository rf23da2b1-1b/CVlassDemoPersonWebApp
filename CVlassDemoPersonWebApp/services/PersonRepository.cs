using CVlassDemoPersonWebApp.model;

namespace CVlassDemoPersonWebApp.services
{
    public class PersonRepository
    {
        private List<Person> _personer;

        public PersonRepository(bool mockData = false)
        {
            _personer = new List<Person>();

            if (mockData)
            {
                PopulatePersonerWithTestData();
            }
        }

        private void PopulatePersonerWithTestData()
        {
            _personer.Clear();

            _personer.Add(new Person(5, "peter", "roskilde"));
            _personer.Add(new Person(10, "jakob", "hvalsø"));
            _personer.Add(new Person(15, "anders", "roskilde"));
            _personer.Add(new Person(20, "per", "ringsted"));

        }

        /*
         * Metoder
         */

        public List<Person> HentAllePersoner()
        {
            return new List<Person>(_personer);

        }

        public void Tilføj(Person person)
        {
            _personer.Add(person);
        }


        /*
         * 
         * HentPerson(int id)
         * SletPerson(int id)
         * ....
         */

    }
}
