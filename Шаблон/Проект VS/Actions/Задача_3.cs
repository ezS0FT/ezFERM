using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.Actions
{
    public class Задача_3 : IAction
    {
        public WorkResult RunAction()
        {
            Instance.ActiveTab.Navigate("https://www.google.ru/");
            return WorkResult.Удачно;
        }
    }
}