using System;

namespace DatingProfile
{
    public class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            { this.name = name; }
            { this.age = age; }
            { this.city = city; }
            { this.country = country; }
            { this.pronouns = pronouns; }
        }
        public string ViewProfile()
        {
            string view = $"Name: {name} \nAge: {age} \nCity: {city} \nCountry: {country} \nPronouns: {pronouns}";
            view += "\nHobbies: \n";
            foreach (string hobby in hobbies)
            {
                view += $"- {hobby}\n";
            }
            // ouput = Name: Sam Drakkila, Age: 30, City: New York, Country: USA, Pronouns: he/him, Hobbies: System.String[]
            // Name: Sam Drakkila, Age: 30, City: New York, Country: USA, Pronouns: he/him, Hobbies: listening to audiobooks and podcasts, playing rec sports like bowling and kickball, writing a speculative fiction novel, reading advice columns
            return view;
        }
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
