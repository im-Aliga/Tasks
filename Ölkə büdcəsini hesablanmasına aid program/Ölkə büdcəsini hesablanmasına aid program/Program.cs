// See https://aka.ms/new-console-template for more information
{
    string budget = "Budget($):"; int countryBudget = 10000000;
    string ToTheMinistryOfDefens = "To the Ministry of Defense($):";   float spentMOD = 10000000f * 20f / 100f;
    string ToTheMinistryOfHighTechnologies = "To the Ministry of High Technologies($):"; float spentMOHT = 10000000f * 10f / 100f;
    string TheRestOfTheBudgetFloat = "The rest of the budget($):"; float residueBudget = countryBudget - spentMOD - spentMOHT;

    Console.WriteLine(budget);
    Console.WriteLine(countryBudget);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(ToTheMinistryOfDefens);
    Console.WriteLine(spentMOD);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(ToTheMinistryOfHighTechnologies);
    Console.WriteLine(spentMOHT);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(TheRestOfTheBudgetFloat);
    Console.WriteLine(residueBudget);







}