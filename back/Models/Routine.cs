﻿using System.ComponentModel.DataAnnotations;

namespace back.Models;

public partial class Routine
{
    public Guid Uuid { get; set; }

    [Required]
    public Guid UserId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public int IntervalInDays { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public User User { get; set; } = null!;
    
    public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();

    public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
}
