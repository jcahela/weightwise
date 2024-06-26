using System.ComponentModel.DataAnnotations;
using back.Models;

namespace back.Dtos;

public record UserDto(
  Guid Uuid,
  [Required] string Username,
  [Required] string Email,
  ICollection<RoutineDto> Routines,
  [Required] DateTime CreatedAt,
  [Required] DateTime UpdatedAt,
  DateTime? DeletedAt
);
