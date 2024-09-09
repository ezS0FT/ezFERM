using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.SubActions
{
    public class Отчиска_таблицы_активности : ISubAction
    {
        public WorkResult RunSubAction()
        {
            string tableName = "Активности";
            int rowNumber = CommonCode.RowNumber(tableName);
            var table = Project.Tables[tableName];

            table.SetCell("B", rowNumber, "");
            table.SetCell("C", rowNumber, "");
            table.SetCell("D", rowNumber, "");
            table.SetCell("E", rowNumber, "");
            table.SetCell("F", rowNumber, "");

            return WorkResult.Удачно;
        }
    }
}