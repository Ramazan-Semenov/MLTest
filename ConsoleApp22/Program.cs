using ConsoleApp22ML.Model;
using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelInput sampleData = new ModelInput()
            {
                Title = @"",
                Description = @"Remove hashtable & friends compiled files from System.Runtime.Extensions	This commit needs to be reverted when the new uapaot build (that contains the hashtable changes) is ingested"
            };

            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Использование модели, чтобы сделать один прогноз -- Сравнение фактической области с прогнозируемой областью из данных образца ...\n\n");
            Console.WriteLine($"Заголовок: {sampleData.Title}");
            Console.WriteLine($"Описание: {sampleData.Description}");
            Console.WriteLine($"\n\nПрогнозируемая область зоны: {predictionResult.Prediction} \nПрогнозируемая Облость множеств: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== Конец процесса ===============");
            Console.ReadKey();
        }
    }
}
