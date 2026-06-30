using System;
using System.Linq;

using System;
using System.Linq;
//11.40
int[] arr = { -3, 5, 0, -1, 12, -7, 8, -2 };
var result = arr
    .Where(x => x >= 0)         
    .Concat(arr.Where(x => x < 0)) 
    .ToList();
Console.WriteLine(string.Join(" ", result));



//13.38
class Team
{
    public string Name { get; set; } = null!;
    public int Points { get; set; }
}
var teams = new List<Team>
{
    new Team { Name = "Спартак", Points = 45 },
    new Team { Name = "Зенит", Points = 62 },
    new Team { Name = "Локомотив", Points = 51 },
    new Team { Name = "ЦСКА", Points = 58 },
    new Team { Name = "Динамо", Points = 37 },
    new Team { Name = "Ростов", Points = 41 },
    new Team { Name = "Краснодар", Points = 55 },
    new Team { Name = "Рубин", Points = 29 },
    new Team { Name = "Ахмат", Points = 33 },
    new Team { Name = "Урал", Points = 25 },
    new Team { Name = "Пари НН", Points = 28 },
    new Team { Name = "Факел", Points = 31 },
    new Team { Name = "Оренбург", Points = 39 },
    new Team { Name = "Торпедо", Points = 22 },
    new Team { Name = "Сочи", Points = 47 },
    new Team { Name = "Химки", Points = 19 },
    new Team { Name = "Арсенал", Points = 35 },
    new Team { Name = "Балтика", Points = 17 },
    new Team { Name = "Алания", Points = 14 },
    new Team { Name = "Тюмень", Points = 11 }
};
var champion = teams.MaxBy(t => t.Points);
Console.WriteLine($"Чемпион: {champion!.Name} ({champion.Points} очков)");

var top3 = teams
    .OrderByDescending(t => t.Points)
    .Take(3)
    .ToList();

var second = top3[1];
var third = top3[2];

Console.WriteLine($"2-е место: {second.Name} ({second.Points} очков)");
Console.WriteLine($"3-е место: {third.Name} ({third.Points} очков)");
