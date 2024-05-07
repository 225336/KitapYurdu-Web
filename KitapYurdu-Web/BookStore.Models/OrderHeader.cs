using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BookStore.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public double OrderTotal {  get; set; }
        public string? OrderStatus {  get; set; }
        public string? PaymentStatus { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Carrier { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateOnly PaymentDueDate {  get; set; }
        public string? SessionId { get; set; }
        public string? PaymentIntentId {  get; set; }
        [Required]
        [DisplayName("Yayınevi")]
        public string? Name { get; set; }
        [DisplayName("Adresi")]
        public string? StreetAddress { get; set; }
        [DisplayName("Şehir")]
        public string? City { get; set; }
        [DisplayName("İlçe")]
        public string? State { get; set; }
        [DisplayName("Posta Kodu")]
        public string? PostalCode { get; set; }
        [DisplayName("Telefonu")]
        public string? PhoneNumber { get; set; }
    }
}
