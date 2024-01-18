internal class DiceRoll // second class as required by the rules
{
    public int[] PassDice(int diceRolls) //This accepts the user input from the other class
    {
        Random random = new Random();
        int[] results = new int[diceRolls]; //creates the array

        for (int i = 0; i < diceRolls; i++) //For loop for as many times as the user indicated
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            // Store the result in the array
            results[i] = dice1 + dice2;
        }

        return results;
    }
}
