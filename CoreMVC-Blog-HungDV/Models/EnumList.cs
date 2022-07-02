﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_Blog_HungDV.Models
{
    public class EnumList
    {
        private List<Category> listCategory;
        private List<Position> listPosition;
        public EnumList()
        {
            this.listCategory = new List<Category>
            {
                new Category(0, "Kinh tế"),
                new Category(1, "Thế Giới"),
                new Category(2, "Chính Trị"),
                new Category(3, "Showbit"),
                new Category(4, "Thời Sự"),
                new Category(5, "Giải Trí"),
                new Category(6, "Kinh Doanh"),
                new Category(7, "Giáo Dục"),
                new Category(8, "Thể Thao"),
                new Category(9, "Thể Thao"),
                new Category(10, "Thể Thao"),
                new Category(11, "Thể Thao")
            };
            this.listPosition = new List<Position>
            {
                new Position(1, "Việt Nam"),
                new Position(2, "Châu Á"),
                new Position(3, "Châu Âu"),
                new Position(4, "Châu Mỹ")
            };
        }

        public List<Category> ListCategory { get => listCategory; }
        public List<Position> ListPostion { get => listPosition; }
    }
}