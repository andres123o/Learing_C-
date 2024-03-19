System.Random random = new System.Random();


// Welcome
Console.WriteLine("HELLO, WELCOME!!");
Console.WriteLine("Don you want to play 21 or another videogame? => Yes/No");

// Variables
string confirmStar = Console.ReadLine();
int numberCoin;
int computerCart;
int playerCart;
string desicion;
int totalPlayer;
string seconDesicion;
int num = 0;
string endDesicion;

// Confirmación de entrada - estado
switch (confirmStar)
{
    case "Yes":
        Console.WriteLine("How many coins do you have?");
        numberCoin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Great, you have {numberCoin} opportunities");
        for (int i = 0; i < numberCoin; i++) {
            Console.WriteLine("Take a card => Yes/No");
            desicion = Console.ReadLine();
            switch (desicion) {
                case "Yes":
                    computerCart = random.Next(12, 21);
                    playerCart = random.Next(1, 25);
                    Console.WriteLine($"Your card is {playerCart}");
                    Console.WriteLine("Do you want to take other card? => Yes/No");
                    seconDesicion = Console.ReadLine();
                    
                    switch (seconDesicion) {
                        case "No":
                            if (playerCart > computerCart && playerCart <= 21) {
                                Console.WriteLine($"Your card is: {playerCart} and The computer is: {computerCart}");
                                Console.WriteLine("Congratulation, you win!!");
                            } else if (playerCart < computerCart || playerCart == computerCart) {
                                Console.WriteLine($"Your card is: {playerCart} and The computer is: {computerCart}");                               
                                Console.WriteLine("You lost, game over!! :(");
                            } else {
                                Console.WriteLine("Invalid Code");
                            }
                            break;

                        case "Yes":
                            totalPlayer = playerCart;
                            totalPlayer = totalPlayer + random.Next(1, 21);
                            Console.WriteLine($"Your card is: {totalPlayer}");
                            Console.WriteLine("Do you want other card? => Yes/No");
                            endDesicion = Console.ReadLine();      
                            while (endDesicion == "Yes" && totalPlayer < 21) {
                                totalPlayer = totalPlayer + random.Next(1, 21);
                                Console.WriteLine($"Your card is: {totalPlayer}");
                                Console.WriteLine("Do you want other card? => Yes/No ");
                                endDesicion = Console.ReadLine();  
                            }

                            if (totalPlayer > computerCart && totalPlayer <= 21) {
                                Console.WriteLine($"Your card is: {totalPlayer} and The computer is: {computerCart}");
                                Console.WriteLine("Congratulation, you win!!");
                            } else if (totalPlayer < computerCart || totalPlayer == computerCart) {
                                Console.WriteLine($"Your card is: {totalPlayer} and The computer is: {computerCart}");                               
                                Console.WriteLine("You lost, game over!! :(");
                            } else if (totalPlayer > 21) {
                                Console.WriteLine($"Sorry but your card is: {totalPlayer}, game over, you lost!! :(");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Code");
                            break;
                    }
                    
                    break;
                default:
                    Console.WriteLine("Invalid Error");
                    break;
            }      
            Console.WriteLine("-----------  THIS ROUND HAS ENDED, LETS'GO WITH THE NEXT  -----------");                
        }
        break;
    case "No":
        Console.WriteLine("You're screwed because there is only 21");
        break;
    default:
        Console.WriteLine("Invalid code");
        break;
}