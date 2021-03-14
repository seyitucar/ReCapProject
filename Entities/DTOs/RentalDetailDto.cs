using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; } //ok
        public string BrandName { get; set; }
        public string CarName { get; set; } // ok
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; } //ok
        public DateTime? ReturnDate { get; set; } //ok

    }
}
