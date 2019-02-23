using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // student information
            // create variables of different data types
            string firstName;
            string lastName;
            string birthDate;
            string address;
            string city;
            string state;
            int zipCode;
            string country;

            // Assign some values
            firstName = "Eilis";
            lastName = "Lee";
            birthDate = "May 2nd";
            address = "500 East Jackson Street";
            city = "New York";
            state = "WA";
            zipCode = 98188;
            country = "USA";

            // teacher information
            // create variables of different data types
            string teacherfirstName;
            string teacherlastName;
            string teacherbirthDate;
            string teacheraddress;
            string teachercity;
            string teacherstate;
            string teacherzip;
            string teachercountry;

            // Assign some values
            teacherfirstName = "John";
            teacherlastName = "Jackson";
            teacherbirthDate = "July 4th";
            teacheraddress = "100 South Hollywood Blvd";
            teachercity = "Pleasantville";
            teacherstate = "WA";
            teacherzip = "98032";
            teachercountry = "USA";

            // UProgram information
            // create variables of different data types
            string programName;
            string departmentHead;
            string degrees;

            // Assign some values
            programName = "Mathematics";
            departmentHead = "Mr. Duke";
            degrees = "Masters";


            Console.WriteLine("The student's name is " + firstName);
            Console.WriteLine(firstName + "'s last name is " + lastName);
            Console.WriteLine(firstName + "'s birthday is on " + birthDate);
            Console.WriteLine(firstName + "'s address is: " + address + ", " + city + ", " + state + ", " + zipCode + ", " + country);
            Console.WriteLine(teacherfirstName + " " + teacherlastName + " was born on " + teacherbirthDate);
            Console.WriteLine("Mr. " + teacherlastName + "'s address is " + teacheraddress + " " + teachercity + " " + teacherstate + " " + teacherzip + " " + teachercountry);
            Console.WriteLine("Mr. " + teacherlastName + "'s boss's name is " + departmentHead + " who is head of the " + degrees + " program of " + programName);
            Console.ReadLine();

        }
    }
}
