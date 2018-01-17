using System;
using System.ComponentModel.DataAnnotations;

namespace Task_2_Akulov_Viacheslav.Models
{
    /// <summary>
    /// Comment entity
    /// </summary>
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
    }
}