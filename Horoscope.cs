string inp;

Console.Write("Enter your zodiac sign : ");
inp = Console.ReadLine();
Console.WriteLine();
Console.Write("Your horoscope : ");
switch (inp)
{
    case "Aries":
    case "aries":
        Console.WriteLine("Your lucky color is Red. Your lucky number is 2. You cannot just sit there and wait for poeple to give you that golden dream. You have to go out there and make it happen. -Diana Ross");
        break;

    case "Taurus":
    case "taurus":
        Console.WriteLine("Your lucky color is Green. Your lucky number is 4. Success to me is having ten honeydew melons and eating only the top half of each slice. -Barbra Streisand");
        break;

    case "Gemini":
    case "gemini":
        Console.WriteLine("Your lucky color is Yellow. Your lucky number is 6. The important thing is not to stop questioning. Curiosity has its own reason for excisting. -Albert Einstein");
        break;

    case "Cancer":
    case "cancer":
        Console.WriteLine("Your lucky color is White and Silver. Your lucky number is 8. I can do things you cannot. You can do things I cannot. Together we can do  great things. -Mother Teresa");
        break;

    case "Leo":
    case "leo":
        Console.WriteLine("Your lucky color is Gold. Your lucky number is 10. Only when you can be extremely pilable and soft can you be extremely hard and strong. -Zen Proverb");
        break;

    case "Virgo":
    case "virgo":
        Console.WriteLine("Your lucky color is Green and Brown. Your lucky number is 12. Most people send more time and energy going around problems than in trying to solve them. -Henry Ford");
        break;

    case "Libra":
    case "libra":
        Console.WriteLine("Your lucky color is Pink and Blue. Your lucky number is 14. If the human race wishes to have a prolonged and indefinite period of material property and indefinite period of material property, they have only got to behave in a peaceful and helpful way toward one another -Winston Churchill");
        break;

    case "Scorpio":
    case "scorpio":
        Console.WriteLine("Your lucky color is Black. Your lucky number is 16.If you shift your focus from yourself to others, extend your concern to others, and cultivate the thought of caring for the well-being of others, then this will have the immediate effect of opening up your life and helping you to reach out. —The Dalai Lama");
        break;

    case "Sagittarius":
    case "sagittarius":
        Console.WriteLine("Your lucky color is Purple. Your lucky number is 18. The world is full of magic things, patiently waiting for our senses to grow sharper. —William Butler Yeats");
        break;

    case "Capricorn":
    case "capricorn":
        Console.WriteLine("Your lucky color is Brown and Gray. Your lucky number is 20. There are some things so serious, you have to laugh at them.  —Niels Bohr");
        break;

    case "Aquarius":
    case "aquarius":
        Console.WriteLine("Your lucky color is Blue. Your lucky number is 22. Lift up your hearts. Each new hour holds new chances. For new beginnings —Maya Angelou");
        break;

    case "Pisces":
    case "pisces":
        Console.WriteLine("Your lucky color is Light Green. Your lucky number is 24. Music gives a soul to the universe, wings to the mind, flight to the imagination, and life to everything. -Plato");
        break;
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadLine();

