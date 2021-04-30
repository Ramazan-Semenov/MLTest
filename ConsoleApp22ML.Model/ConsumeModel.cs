
using Microsoft.ML;
using System;

namespace ConsoleApp22ML.Model
{
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

        // Метод для вывода результата
        public static ModelOutput Predict(ModelInput input)
        {
            ModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }
        // метод для создания новой модели
        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            // Создание нового MLContext
            MLContext mlContext = new MLContext();

            // Загрузить модель и создать механизм прогнозирования
            string modelPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MLModel.zip");

            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            return predEngine;
        }
    }
}
