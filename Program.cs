using ConsoleFactoryRace;
void Race()
{
    CreatorCar creatorFormulaF1 = new CreatorCarFormulaF1();
    CreatorCar creatorGT1 = new CreatorCarGT1();

    Car formulaF1 = creatorFormulaF1.Creator();
    Car gt1 = creatorGT1.Creator();

    Console.WriteLine("Путь Formula_1");
    new Thread(formulaF1.Move).Start();

    Thread.Sleep(100);

    Console.WriteLine("Путь GT_1");
    new Thread(gt1.Move).Start();
}
Race(); //Решение задачи: 1) Разница в шагах для определение победителя; 2) Чей путь до финиша (2000) был короче в последний шаг.