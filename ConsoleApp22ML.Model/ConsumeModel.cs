
using Microsoft.ML;
using System;

namespace ConsoleApp22ML.Model
{
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

        // ����� ��� ������ ����������
        public static ModelOutput Predict(ModelInput input)
        {
            ModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }
        // ����� ��� �������� ����� ������
        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            // �������� ������ MLContext
            MLContext mlContext = new MLContext();

            // ��������� ������ � ������� �������� ���������������
            string modelPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MLModel.zip");

            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            return predEngine;
        }
    }
}
