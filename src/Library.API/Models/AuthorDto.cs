﻿using System;
using System.Collections.Generic;

namespace Library.API.Models
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Genre { get; set; }
        public ICollection<BookForCreationDto> Books { get; set; }
    }
}