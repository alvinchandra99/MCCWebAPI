using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Employee
    {
        public Employee() { }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
           
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       
        
        [ForeignKey("department")]
        public int DepartementID { get; set; }
        public Department department { get; set; }
        
        //public virtual Department Departments { get; set; }
    }
}