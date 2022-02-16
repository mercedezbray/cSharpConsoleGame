
public class Program {

    public class Question
    {
        public string questionText;
        public string[] listOfAnswers;

        public Question(string questionText, string[] listOfAnswers)
        {
            this.questionText = questionText;
            this.listOfAnswers = listOfAnswers;
        }

        public void printQuestion(){
            Console.WriteLine(this.questionText);
            foreach (var multipleChoice in this.listOfAnswers)
            {
                Console.WriteLine(multipleChoice);
            }
        }
    }

    public static string GetConsoleInput()
    {
            Console.WriteLine("Enter Answer:");
            var playerGuess = Console.ReadLine();
            return playerGuess;
    }

    public static void ShowScore (int score)
    {
      Console.WriteLine($"Current Score = {score}");  
    }

    public static void Main ()
    {
        int score = 0;
        Console.WriteLine("Welcome to the ultimate trivia game!!!! This game will prompt you with a question, and you have to choose the correct answer. If you get the correct answer, you will be awarded with 100 points!!! Get the question wrong and you lose 100 points. There are 10 questions and you must score least 700 ponts to win the game. PLEASE TYPE THE ANSWER EXACTLY AS IT APPEAR IN THE QUESTION! Good luck!!  ");

        var questionOne = new Question("Which country gave the United States the Statue of Liberty?", 
            new []{"Germany", "Italy", "France", "Britian"});

        questionOne.printQuestion();

        var guess1 = GetConsoleInput();
        if (guess1 == "France") 
        {
            Console.WriteLine("Correct! You get 100 point!");
            score += 100;
        }
        else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionTwo = new Question("What was the first animated movie nominated for Best Picture at the Academy Awards?",
            new[]{"Toy Story 3", "Beauty & the Beast", "The Lion King", "Up" });
        
        questionTwo.printQuestion();

        var guess2 = GetConsoleInput();
        if (guess2 == "Beauty & the Beast")
            {
                Console.WriteLine("Correct! You get 100 points!");
                score += 100;
            }
        else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);  

        var questionThree = new Question("Which country consumes the most chocolate per capita?", new[]{"Switzerland", "The United States", "Mexico", "Spain"});

        questionThree.printQuestion();

        var guess3 = GetConsoleInput();
        if (guess3 == "Switzerland")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
        else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score); 

        var questionFour = new Question("Which musical act has the most number one hits of all time?", new[]{"Mariah Carey", "Elvis Presley", "Rihanna", "The Beatles"});

        questionFour.printQuestion();

        var guess4 = GetConsoleInput();
        if (guess4 == "The Beatles")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
        else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score); 

        var questionFive = new Question("Where did the 1996 Summer Olympics Games take place?", new[]{"Atlanta, USA", "Nagano, Japan", "Barcelona, Spain", "Sydney, Australia"});
        
        questionFive.printQuestion();

        var guess5 = GetConsoleInput();
        if (guess5 == "Nagano, Japan")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
        else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionSix = new Question("What year did Michael Jordan retire for the second time?", new[]{"1998", "2001", "1996", "2003"});

        questionSix.printQuestion();

        var guess6 = GetConsoleInput();
        if (guess6 == "2003")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
         else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionSeven = new Question("What year did the first Star Wars Movie come out?", new[]{"1989", "1999", "2000", "1977"});

        questionSeven.printQuestion();

        var guess7 = GetConsoleInput();
        if (guess7 == "1977")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
         else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionEight = new Question("What year was apple founded?", new[]{"1966", "1976", "1986","1996"});

        questionEight.printQuestion();

        var guess8 = GetConsoleInput();
        if (guess8 == "1976")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
         else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionNine = new Question("When was Indiana founded as a state?", new[]{"1812", "1816", "1820", "1825"});

        questionNine.printQuestion();

        var guess9 = GetConsoleInput();
        if (guess9 == "1816")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
         else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        var questionTen = new Question("How many years are in between each summer olympic games?", new[]{"2", "3", "4", "6"});

        questionTen.printQuestion();

        var guess10 = GetConsoleInput();
         if (guess10 == "4")
        {
            Console.WriteLine("Correct! You get 100 points!");
                score += 100;
        }
         else {
            Console.WriteLine("Wrong! You lost 100 point!");
            score -= 100;
        }
        ShowScore (score);

        if (score >= 700){
            Console.WriteLine("Congratulations! You won the game! You are the trivia master");
        }
        else {
            Console.WriteLine("You did not score 700 points! Try again next time!");
        }
    }

}
