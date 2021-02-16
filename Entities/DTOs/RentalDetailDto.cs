using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }      
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BrandId { get; set; }
        public decimal DailyPrice { get; set; }
        public int UserId { get; set; }
        public string CompanName { get; set; }
    }
}
