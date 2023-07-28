using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir açıklama giriniz.")]
        public string Description { get; set; } 

        [Required(ErrorMessage = "Lütfen bitiş tarihi giriniz.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Lütfen kategori seçiniz")]
        public string CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

        [Required(ErrorMessage = "Lütfen durum seçiniz")]
        public string StatusId { get; set; }
        [ValidateNever]
        public Status Status { get; set; }

        public bool OverDue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
