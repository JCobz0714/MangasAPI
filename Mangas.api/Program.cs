using Mangas.api.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<MangaDTO> mangas = [
    new (
        1,
        "One Piece",
        "Adventure",
        new DateOnly(1997, 07, 22)
    ),
    new (
        2,
        "Naruto",
        "Adventure",
        new DateOnly(1999, 09, 21)
    ),
    new (
        3,
        "Bleach",
        "Adventure",
        new DateOnly(2001, 08, 07)
    )
];

app.MapGet("mangas", () => mangas);

app.MapGet("/", () => "Hello World!");

app.Run();
