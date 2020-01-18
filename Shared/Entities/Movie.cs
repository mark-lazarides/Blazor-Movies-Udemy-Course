using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
  public class Movie
  {
    [Required(ErrorMessage = "Movie title is required.")]
    [StringLength(maximumLength: 15, ErrorMessage = "Max length is 15 characters.")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Release date is required.")]
    public DateTime ReleaseDate { get; set; }
  }
}
