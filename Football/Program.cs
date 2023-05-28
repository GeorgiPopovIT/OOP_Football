using Football.Contracts;
using Football.Models;

var torWarten = new Goalkeeper("Хидайет Ханкич", 24, 1, 180);

var genevDefender = new Defender("Виктор Генев", 32, 3, 189);
var defSupayen = new Defender("Самуел Супрайен", 34, 3, 189);
var PuncecDef = new Defender("Роберто Пунчец", 33, 3, 189);


var pereraMid = new Midfield("Антонио Перера", 23, 3, 189);
var kolevMid = new Midfield("Красиан Колев", 18, 3, 189);
var HermanMid = new Midfield("Рой Херман", 22, 3, 189);
var etooMid = new Midfield("Джеймс Ето'о", 21, 3, 189);

var baroanStriker = new Striker("Антоан Бароан", 21, 3, 189);
var umeStriker = new Striker("Уме Емануел", 20, 3, 189);
var sekulicStriker = new Striker("Мартин Секулич", 20, 3, 189);



var homeTeam = new Team(torWarten, genevDefender,
    defSupayen, PuncecDef, pereraMid, HermanMid,
    kolevMid, etooMid, baroanStriker,
    umeStriker, sekulicStriker);
homeTeam.Coach = new Coach("Stefan Stoyanov",49);

var torWarten2 = new Goalkeeper("Гай Бубакар", 24, 1, 180);

var def1 = new Defender("Мaзан", 32, 3, 189);
var def2 = new Defender("David Malembana", 34, 3, 189);
var def3 = new Defender("Mateus Duarte", 33, 3, 189);


var mid1 = new Midfield("Krasimir Miloshev", 23, 3, 189);
var mid2 = new Midfield("Martin Raynov", 18, 3, 189);
var mid3 = new Midfield("Dimo Bakalov", 22, 3, 189);
var mid4 = new Midfield("Celso Raposo", 21, 3, 189);

var striker1 = new Striker("Yulian Nenov", 21, 3, 189);
var striker2 = new Striker("Antonio Vutov", 20, 3, 189);
var striker3 = new Striker("Karlos Franca", 20, 3, 189);

var awayTeam = new Team(torWarten2, def1,
    def2, def3, mid1, mid2,
    mid3, mid4, striker1,
    striker2, striker3);

var ref1 = new Referee("Georgi Kabakov", 42);
var ref2 = new Referee("Martin Margaritov", 40);
var ref3 = new Referee("Diyan Valkov", 39);


var game = new Game(homeTeam,awayTeam,ref1,ref2,ref3);
game.Goals = new List<Dictionary<int, Football.Contracts.FootballPlayer>>
{
    new Dictionary<int,FootballPlayer>()
    {
        {12,def1 },
        {45, PuncecDef },
        {78, baroanStriker }
    }
};

Console.WriteLine(game.Result);
Console.WriteLine(game.Winner);



