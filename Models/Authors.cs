/*
                        AUTHORS CLASS
    holds all information for the Author table in the
    database. All the variables should correspong to 
    each of the columns/elements of the Author table.
 
 */

using System;
using System.Collections.Generic; //Taken from this tutorial https://www.youtube.com/watch?v=rTXozMmFVqA
using System.Linq;                //Also taken from this tutorial ^
using System.Threading.Tasks;     //This one too

namespace CPMS.Models
{
    public class Authors
    {
        [System.ComponentModel.DataAnnotations.Key] //identifies AuthorID as Primary Key
        public int AuthorID { get; set; }
        public string? FirstName { get; set; }
        public char? MiddleInitial { get; set; }
        public string? LastName { get; set; }
        public DateOnly? DOB { get; set; }
        public string? Affiliation { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }//end public class Authors
}//end namespace CPMS.Models

