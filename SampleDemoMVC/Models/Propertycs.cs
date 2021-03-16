using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Models
{
    public class Propertycs
    {
        [Key]
        public int PropertyID { get; set; }
        [Display(Name = "Property ID")]

        public string PropertyName { get; set; }
        [Display(Name = "Property Name")]

        public string PropertyLocation { get; set; }
        [Display(Name = "Property Location")]

        public string County { get; set; }
        [Display(Name = "Property County")]

        public string City { get; set; }
        [Display(Name = "Property City")]

        public string PostCode { get; set; }
        [Display(Name = "Post Code")]

        public string NoofRooms { get; set; }
        [Display(Name = "No of Rooms")]

        public bool ElectricityAvaillable { get; set; }
        [Display(Name = "Electricity Availlable")]

        public bool WaterAvaillable { get; set; }
        [Display(Name = "Water Availlable")]

        public bool ParkingAvaillable { get; set; }

    }
}
