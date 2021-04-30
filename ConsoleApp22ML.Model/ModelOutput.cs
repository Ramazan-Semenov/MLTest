
using Microsoft.ML.Data;
using System;

namespace ConsoleApp22ML.Model
{
    public class ModelOutput
    {
        // ������� ColumnName ������������ ��� ��������� ����� ������� �
        [ColumnName("PredictedLabel")]
        public String Prediction { get; set; }
        public float[] Score { get; set; }
    }
}
