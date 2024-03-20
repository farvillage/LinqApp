using System;
using LinqApp;

var songs = new List<Songs>
{
    new Songs(id:1, name:"Bohemian Rhapsody", band: "Queen", new DateTime(year: 1975, month: 10, day: 31)),
    new Songs(id: 2, name:"Newborn me", band:"Angra", new DateTime(year: 2014, month: 12, day: 17)),
    new Songs(id: 3, name:"November Rain", band:"Guns N' Roses", new DateTime(year: 1991, month: 03, day: 18)),
    new Songs(id: 4, name: "The Show Must Go On", band: "Queen", new DateTime(year: 1991, month: 10, day: 14))
};

Console.WriteLine("Songs released in 1991: ");
var songs1991 = songs
    .Where(x => x.ReleaseDate.Year == 1991)
    .ToList();
foreach (var item in songs1991)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Songs released in October: ");
var songsOctober = songs
    .Where(x => x.ReleaseDate.Month == 10)
    .ToList();
foreach (var item in songsOctober)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Return songs in alphabetical order: ");
var songsAZ = songs
    .OrderBy(x => x.Name)
    .ToList();
foreach (var item in songsAZ)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Last two songs registered in alphabetical order: ");
// var songsLastTwo = songs
//     .OrderBy(x => x.Name.TakeLast(2))
//     .ToList();
// foreach (var item in songsLastTwo)
// {
//     Console.WriteLine(item.ToString());
// }
    