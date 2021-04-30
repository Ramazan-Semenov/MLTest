
using Microsoft.ML.Data;

namespace ConsoleApp22ML.Model
{
    //Модель данных
    public class ModelInput
    {
        [ColumnName("ID"), LoadColumn(0)]
        public float ID { get; set; }


        [ColumnName("Area"), LoadColumn(1)]
        public string Area { get; set; }


        [ColumnName("Title"), LoadColumn(2)]
        public string Title { get; set; }


        [ColumnName("Description"), LoadColumn(3)]
        public string Description { get; set; }


    }
}
