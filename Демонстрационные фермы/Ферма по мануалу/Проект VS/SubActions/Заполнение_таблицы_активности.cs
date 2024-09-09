using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.SubActions
{
    public class Заполнение_таблицы_активности : ISubAction
    {
        // Имя подзадачи = имя класса.
        // Строки кода вашей подзадачи внутри тела метода RunSubAction().
        public WorkResult RunSubAction()
        {
            string tableName = "Активности";
            int rowNumber = CommonCode.RowNumber(tableName);
            var table = Project.Tables[tableName];

            table.SetCell("B", rowNumber, "1");
            table.SetCell("C", rowNumber, "1");
            table.SetCell("D", rowNumber, "1");
            table.SetCell("E", rowNumber, "1");
            table.SetCell("F", rowNumber, "1");

            return WorkResult.Удачно;
        }
    }
}