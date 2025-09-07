namespace MyDomain
{
    public class Person
    {
        public string? Firstname { get; set; } = "";
        public string? MiddleName { get; set; } = "";
        public string? LastName { get; set; } = "";
        public DateTime Birthdate { get; set; }

        public string FullName
        {
            get
            {
                return String.Concat(
                    "|", Firstname, " ",
                    String.Concat(MiddleName, " ").TrimStart(),
                    LastName, "|");

            }
        }

        public int Age
        {
            get {
                int a = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month == Birthdate.Month)
                {
                    if (DateTime.Now.Day < Birthdate.Day)
                    {
                        a--;
                    }
                }
                else if (DateTime.Now.Month < Birthdate.Month)
                {
                    a--;
                }
                return a;
            }
        }
    }
}