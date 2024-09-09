using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.Actions
{
    public class Задача_5 : IAction
    {
        // Имя задачи = имя класса.
        // Строки кода вашей задачи внутри тела метода RunAction().
        public WorkResult RunAction()
        {
            Instance.ActiveTab.Navigate("https://ya.ru/");
            return WorkResult.Удачно;
        }
    }
}