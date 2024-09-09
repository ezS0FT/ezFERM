using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.Actions
{
    public class Задача_2 : IAction
    {
        public WorkResult RunAction()
        {
            Instance.ActiveTab.Navigate("https://r0.ru/");
            return WorkResult.Удачно;
        }
    }
}