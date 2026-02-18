using System.ComponentModel.DataAnnotations;

namespace PokemonTabletopAdventures.Models.Pokemons;

public class EvolvePokemonData
{
    [Required, MinLength(1), MaxLength(255)]
    public required string NextForm { get; set; }
    public required ICollection<string> KeptMoves { get; set; }
    public required ICollection<string> NewMoves { get; set; }
}
