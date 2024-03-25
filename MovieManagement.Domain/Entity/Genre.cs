﻿namespace MovieManagement.Domain.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;    
        public List<Movie>? Movies { get; set; }
    }
}