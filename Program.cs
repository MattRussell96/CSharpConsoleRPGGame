
// Start of game intro
using NewGame;


Console.Write("Hello there neighbor may I ask your name : ");

// Player is to enter name
Player player = new Player()
{
    Name = Console.ReadLine()
};

// Story and first choice options
Console.WriteLine("\nPrepare for war " + player.Name + "!" + " Your dog is in need of rescuing, Karen and her evil family stole your puppy Froggy! Will you help rescue him?\n\nIf yes then type yes and enter the house of death to retrieve him!\n\nOr type no and turn around, I guess I didn't take you for a cat lover...\n");

// Giving the player a moral option to help or leave... or are we!
string answer1 = Console.ReadLine();

switch(answer1)
{
    case "yes":
    Console.WriteLine("\nThank you very much you hard work will be much appreciated please don't die in there!\n");
    break;
    case "no":
    Console.WriteLine("\nToo bad I will see you on the other side!\n");
    break;
}

// Tutorial for how you lose or how you win the game!
Console.WriteLine("Now " + player.Name + " your objective is to get in, defeat the evil family and rescue poor Froggy from the clutches of the almighty and vile Karen. To do this you will be prompted to choose an action number from 1-4 to increase your chances of making it out of this house full of NAGGING and DEATH! As you progress you may have the option for an enhancer at the expense of life points choose wisely and you shall defeat her with ease or make the wrong choice and perish leaving Froggy all alone with no one to save him.\n\nYou have damage based off of your choices and the enemys will have their base damage on top of what is dealt, and below are your actions!\n\n1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - .5 life point!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");

Console.WriteLine("Listed here are the residents of this house, your enemies from weakest to strongest do not take them for granted their family dinamic toxic! so they are always willing to attack!\n");

string mainBoss = "Karen";
string[] bosses = new string[] { "Corey", "Becky", "Kyle", mainBoss};
foreach (string name in bosses)
{
    Console.WriteLine(name + "\n");
}

Console.WriteLine("Even their names give me the willies good luck " + player.Name + " and may the all mighty be with you on your journey!\n");

Console.WriteLine("As you approach the house you come up on an item box with a message saying Please Open! Do you open it yes or no?\n");

string openBox = Console.ReadLine();

switch(openBox)
{
    case "yes":
    Console.WriteLine("\nYou open the item box and find Body Armor! this increase your life points by 10 and you move on.\n");
    player.healthPoints = player.healthPoints + 10;
    break;
    case "no":
    Console.WriteLine("\nYou leave the box closed worrying that something dangerous could have been placed inside it as a trap. You exclame I am not falling for that HAHA and move on.\n");
    break;
}

Console.WriteLine("As you make your way into the house you notice that the house has a strong smell of kale and juice cleanses and you think to yourself this definitley is the place!\n\nYou continue forward you notice a vent in the ceiling and you can hear people arguing through it. Do you want to listen in or keep exploring yes or no?\n\n");

string listenTo = Console.ReadLine();

switch(listenTo)
{
    case "yes":
    Console.WriteLine("\nYou strain to put your ear to the vent and hear the shrill shrieks of Karen arguing with Kyle her husband and your ears start to bleed! this decrease your life points by 10 and you move on.\n");
    player.healthPoints = player.healthPoints - 10;
    break;
    case "no":
    Console.WriteLine("\nYou choose not to listen and continue looking for your puppy as quickly as you can. You may not know it but you saved yourself from Karens nagging and you gain 10 life points and move on.\n");
    player.healthPoints = player.healthPoints + 10;
    break;
}

Console.WriteLine("As you turn the corner you see the son Corey sitting on the couch watching tv. You go to sneak by and trip over a set of 20lb dumbells... He turns around and yells WHO ARE YOU, ARE YOU BREAKING INTO MY HOUSE, THOSE ARE MINE BRO! Then the battle begins!\n\n");

Console.WriteLine(player.Name + " You have encountered Corey and he is coming for blood! What will you do?\n\n");

    
    MiniBoss1 corey = new MiniBoss1(30, 1, "Corey");
    Console.WriteLine(corey);
    Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
    Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    
    while(player.healthPoints > 0 && corey.healthPoints > 0 )
{

    string yourInput = Console.ReadLine();
    int numChosen = int.Parse(yourInput);

    if(numChosen == 1)
    {
        Console.WriteLine("Light Attack + 4 damage!\n");
        corey.healthPoints = corey.healthPoints - 4;
        player.healthPoints = player.healthPoints - 1;
        Console.WriteLine(corey);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy Attack + 6 damage - 2 life points!\n");
        corey.healthPoints = corey.healthPoints - 6;
        player.healthPoints = player.healthPoints - 3;
        Console.WriteLine(corey);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Defend + 2 damage - 1.5 life points!\n");
        corey.healthPoints = corey.healthPoints - 2;
        player.healthPoints = player.healthPoints - 2.5;
        Console.WriteLine(corey);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Special Move + 10 damage - 3.5 Life points!\n");
        corey.healthPoints = corey.healthPoints - 10;
        player.healthPoints = player.healthPoints - 4.5;
        Console.WriteLine(corey);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else
    {
        player.healthPoints = player.healthPoints - 200;
        Console.WriteLine("You chose not to make an attack and Corey got a powerfull blow on you and you died!\n");
    }
}
Console.WriteLine("Congratulations you killed " + corey.miniBoss1Name + "!");


MiniBoss2 becky = new MiniBoss2(65, 2, "Becky");
    Console.WriteLine(becky);
    Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
    Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    
    while(player.healthPoints > 0 && becky.healthPoints > 0 )
{

    string yourInput = Console.ReadLine();
    int numChosen = int.Parse(yourInput);

    if(numChosen == 1)
    {
        Console.WriteLine("Light Attack + 4 damage!\n");
        becky.healthPoints = becky.healthPoints - 4;
        player.healthPoints = player.healthPoints - 2;
        Console.WriteLine(becky);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy Attack + 6 damage - 2 life points!\n");
        becky.healthPoints = becky.healthPoints - 6;
        player.healthPoints = player.healthPoints - 4;
        Console.WriteLine(becky);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Defend + 2 damage - 1.5 life points!\n");
        becky.healthPoints = becky.healthPoints - 2;
        player.healthPoints = player.healthPoints - 3.5;
        Console.WriteLine(becky);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Special Move + 10 damage - 3.5 Life points!\n");
        becky.healthPoints = becky.healthPoints - 10;
        player.healthPoints = player.healthPoints - 5.5;
        Console.WriteLine(becky);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else
    {
        player.healthPoints = player.healthPoints - 200;
        Console.WriteLine("You chose not to make an attack and Corey got a powerfull blow on you and you died!\n");
    }
}
Console.WriteLine("Congratulations you killed " + becky.miniBoss2Name + "!");


MiniBoss3 kyle = new MiniBoss3(100, 3, "Kyle");
    Console.WriteLine(kyle);
    Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
    Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    
    while(player.healthPoints > 0 && kyle.healthPoints > 0 )
{

    string yourInput = Console.ReadLine();
    int numChosen = int.Parse(yourInput);

    if(numChosen == 1)
    {
        Console.WriteLine("Light Attack + 4 damage!\n");
        kyle.healthPoints = kyle.healthPoints - 4;
        player.healthPoints = player.healthPoints - 3;
        Console.WriteLine(kyle);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy Attack + 6 damage - 2 life points!\n");
        kyle.healthPoints = kyle.healthPoints - 6;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(kyle);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Defend + 2 damage - 1.5 life points!\n");
        kyle.healthPoints = kyle.healthPoints - 2;
        player.healthPoints = player.healthPoints - 4.5;
        Console.WriteLine(kyle);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Special Move + 10 damage - 3.5 Life points!\n");
        kyle.healthPoints = kyle.healthPoints - 10;
        player.healthPoints = player.healthPoints - 6.5;
        Console.WriteLine(kyle);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else
    {
        player.healthPoints = player.healthPoints - 200;
        Console.WriteLine("You chose not to make an attack and Corey got a powerfull blow on you and you died!\n");
    }
}
Console.WriteLine("Congratulations you killed " + kyle.miniBoss3Name + "!");


MainBoss karen = new MainBoss(250, 4, "Karen");
    Console.WriteLine(karen);
    Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
    Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    
    while(player.healthPoints > 0 && karen.healthPoints > 0 )
{

    string yourInput = Console.ReadLine();
    int numChosen = int.Parse(yourInput);

    if(numChosen == 1)
    {
        Console.WriteLine("Light Attack + 4 damage!\n");
        karen.healthPoints = karen.healthPoints - 4;
        player.healthPoints = player.healthPoints - 5;
        Console.WriteLine(karen);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 2)
    {
        Console.WriteLine("Heavy Attack + 6 damage - 2 life points!\n");
        karen.healthPoints = karen.healthPoints - 6;
        player.healthPoints = player.healthPoints - 6;
        Console.WriteLine(karen);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 3)
    {
        Console.WriteLine("Defend + 2 damage - 1.5 life points!\n");
        karen.healthPoints = karen.healthPoints - 2;
        player.healthPoints = player.healthPoints - 6.5;
        Console.WriteLine(karen);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else if(numChosen == 4)
    {
        Console.WriteLine("Special Move + 10 damage - 3.5 Life points!\n");
        karen.healthPoints = karen.healthPoints - 10;
        player.healthPoints = player.healthPoints - 7.5;
        Console.WriteLine(karen);
        Console.WriteLine(player.Name + ", HP: " + player.healthPoints);
        Console.WriteLine("1.) Light Attack + 4 damage!\n2.) Heavy Attack + 6 damage - 2 life points!\n3.) Defend + 2 damage - 1.5 life points!\n4.) Special Move + 10 damage - 3.5 Life points!\n\n");
    }
    else
    {
        player.healthPoints = player.healthPoints - 200;
        Console.WriteLine("You chose not to make an attack and Corey got a powerfull blow on you and you died!\n");
    }
}
Console.WriteLine("Congratulations you killed " + karen.mainBossName + "!");




namespace NewGame
{

    public class Player
    {
        public double healthPoints { get; set; }
        public int damage { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Name}, Damage: {damage}, HP: {healthPoints}";

        public Player()
        {
            healthPoints = 150;
            damage = 2;
            Name = Name;
        }
    }

    public class MainBoss
    {
        public double healthPoints { get; set; }
        public int damage { get; set; }
        public string mainBossName { get; set; }
        public override string ToString() => $"{mainBossName}, Damage: {damage}, HP: {healthPoints}";
        
        public MainBoss(int hp, int dmg, string name)
        {
            healthPoints = 250;
            damage = 4;
            mainBossName = "Karen";
        }
    }

    public class MiniBoss1
    {
        public double healthPoints { get; set; }
        public int damage { get; set; }
        public string miniBoss1Name { get; set; }
        public override string ToString() => $"{miniBoss1Name}, Damage: {damage}, HP: {healthPoints}";
        public MiniBoss1(int hp, int dmg, string name)
        {
            healthPoints = 30;
            damage = 1;
            miniBoss1Name = "Corey";
        }
    }

    public class MiniBoss2
    {
        public double healthPoints { get; set; }
        public int damage { get; set; }
        public string miniBoss2Name { get; set; }
        public override string ToString() => $"{miniBoss2Name}, Damage: {damage}, HP: {healthPoints}";
        public MiniBoss2(int hp, int dmg, string name)
        {
            healthPoints = 65;
            damage = 2;
            miniBoss2Name = "Becky";
        }
    }

    public class MiniBoss3
    {
        public double healthPoints { get; set; }
        public int damage { get; set; }
        public string miniBoss3Name { get; set; }
        public override string ToString() => $"{miniBoss3Name}, Damage: {damage}, HP: {healthPoints}";
        public MiniBoss3(int hp, int dmg, string name)
        {
            healthPoints = 100;
            damage = 3;
            miniBoss3Name = "Kyle";
        }
    }    
}


