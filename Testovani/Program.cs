using Testovani;

Console.WriteLine("Vítejte v Kvízové hře!");
Console.WriteLine("Vyberte jednu správnou odpověď.\n");

List<Question> questions = new()
{
            new Question("Jaká je hlavní město České republiky?", new List<string> { "Praha", "Brno", "Ostrava", "Plzeň" }, 0),
            new Question("Kolik je základních kamenů v pyramidě v Egyptě?", new List<string> { "3", "4", "5", "6" }, 1),
            new Question("Kdo napsal knihu Romeo a Julie?", new List<string> { "Fyodor Dostoevsky", "Leo Tolstoy", "William Shakespeare", "Jane Austen" }, 2),
            new Question("Jaká řeka protéká Paříží?", new List<string> { "Dunaj", "Rýn", "Seina", "Vltava" }, 2),
            new Question("Který plyšový medvídek je známý pro svou neustálou touhu po medu?", new List<string> { "Winnie the Pooh", "Paddington Bear", "Teddy Ruxpin", "Yogi Bear" }, 0),
            new Question("Který kov je složen z atomů se shodným počtem protonů, ale různým počtem neutronů?", new List<string> { "Olovo", "Měď", "Hliník", "Uran" }, 1),
            new Question("Kdo byl prvním člověkem na Měsíci?", new List<string> { "John Glenn", "Yuri Gagarin", "Neil Armstrong", "Buzz Aldrin" }, 2),
            new Question("Který kontinent je největší podle rozlohy?", new List<string> { "Asie", "Afrika", "Severní Amerika", "Jižní Amerika" }, 0),
            new Question("Kolik je hracích karet v běžném balíčku karet?", new List<string> { "48", "52", "54", "56" }, 1),
            new Question("Který hory tvoří hřeben mezi Evropou a Asií?", new List<string> { "Ural", "Alpy", "Andes", "Himaláje" }, 0),
            new Question("Který prvek je základním stavebním kamenem diamantů?", new List<string> { "Uhlík", "Křemík", "Hlinitan", "Kyslík" }, 0),
            new Question("Kdo napsal knihu Válka světů?", new List<string> { "Isaac Asimov", "H.G. Wells", "Arthur C. Clarke", "Philip K. Dick" }, 1),
            new Question("Jaký je největší oceán na světě?", new List<string> { "Atlantský oceán", "Indický oceán", "Tichý oceán", "Severní ledový oceán" }, 2),
            new Question("Jaký je největší kontinent na světě?", new List<string> { "Austrálie", "Afrika", "Antarktida", "Asie" }, 3),
            new Question("Který je nejvyšší vrchol v Himálaji?", new List<string> { "Everest", "K2", "Makalu", "Annapurna" }, 0),
            new Question("Kdo napsal knihu Válka a mír?", new List<string> { "Fyodor Dostoevsky", "Leo Tolstoy", "Anton Chekhov", "Boris Pasternak" }, 1),
            new Question("Kolik planet je ve sluneční soustavě?", new List<string> { "6", "7", "8", "9" }, 2),
            new Question("Která barva se nachází na vlajce Japonska?", new List<string> { "Červená", "Modrá", "Zelená", "Bílá" }, 3),
            new Question("Kdo byl prvním prezidentem Spojených států amerických?", new List<string> { "George Washington", "Thomas Jefferson", "John Adams", "Benjamin Franklin" }, 0),
            new Question("Která řeka protéká New Yorkem?", new List<string> { "Mississippi", "Hudson", "Colorado", "Missouri" }, 1),
        };

int score = 0;

foreach (var item in questions)
{
    Console.WriteLine(item.Text);

    for (int i = 0; i < item.Options.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {item.Options[i]}");
    }

    int userAnswer = ValidAnswer(1, 4);
    if (userAnswer == item.CorrectAnswer + 1)
    {
        Console.WriteLine("Správně!\n");
        score++;
    }
    else
    {
        Console.WriteLine($"Špatná odpověď! Správná odpověď je: {item.Options[item.CorrectAnswer]}\n");
    }
}

Console.WriteLine($"Konec hry! Vaše scóre je: {score}/{questions.Count}");


static int ValidAnswer(int minValue, int maxValue)
{
    int userAnswer;
    while (true)
    {
        Console.Write("Vaše odpověď: ");
        if (int.TryParse(Console.ReadLine(), out userAnswer) && userAnswer >= minValue && userAnswer <= maxValue)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Vyberte číslo mezi {minValue} a {maxValue}.");
        }
    }
    return userAnswer;
}
