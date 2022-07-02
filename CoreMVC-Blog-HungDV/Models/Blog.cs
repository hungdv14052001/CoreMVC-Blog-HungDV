using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_Blog_HungDV.Models
{
    public class Blog
    {
        private int id;
        private string title;
        private string des;
        private string detail;
        private int category;
        private bool isPublic;
        private DateTime datePublic;
        private List<bool> position;
        private string thumbs;

        public Blog()
        {
            this.id = 0;
            this.title = "";
            this.des = "";
            this.detail = "";
            this.category = 0;
            this.isPublic = true;
            this.datePublic = DateTime.Now;
            this.position = new List<bool> { false, false, false, false };
            this.thumbs = "thumbs.jpg";
        }

        public Blog(int id, string title, string des, string detail, int category, bool isPublic, DateTime datePublic, List<bool> position, string thumbs)
        {
            this.id = id;
            this.title = title;
            this.des = des;
            this.detail = detail;
            this.category = category;
            this.isPublic = isPublic;
            this.datePublic = datePublic;
            this.position = position;
            this.thumbs = thumbs;
        }

        public int Id { get => id; set => id = value; }

        [StringLength(1000, MinimumLength = 3)]
        [Required]
        public string Title { get => title; set => title = value; }

        [StringLength(1000, MinimumLength = 3)]
        [Required]
        public string Des { get => des; set => des = value; }

        [StringLength(1000, MinimumLength = 3)]
        [Required]
        public string Detail { get => detail; set => detail = value; }
        public int Category { get => category; set => category = value; }
        public bool IsPublic { get => isPublic; set => isPublic = value; }

        [Display(Name = "Date Public")]
        [DataType(DataType.Date)]
        public DateTime DatePublic { get => datePublic; set => datePublic = value; }
        public List<bool> Position { get => position; set => position = value; }
        public string Thumbs { get => thumbs; set => thumbs = value; }
    }
}
