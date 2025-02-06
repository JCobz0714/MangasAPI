namespace Mangas.api.DTOs;

public record class MangaDTO(
    int Id, 
    string Name, 
    string Genre,
    DateOnly releaseDate
);