namespace GettersSetters
{

    public class Person
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            // this allows age to be readable
            get { return _age; }
            // this allows age to be writable
            set { _age = value; }
        }


        public bool CanDrink
        {
            get
            {
                return this._age >= 21;
            }
        }

        public Person()
        {
            ;
        }


    }
}