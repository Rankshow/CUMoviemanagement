﻿namespace MovieManagement.Domain.Entity.BaseEntity;

public class BaseEntity
{
    public int Id { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string ModifiedBy {  get; set; } = string.Empty; 
    public DateTime CreatedDate { get; set;}
    public DateTime ModifiedDate { get; set; }
}
