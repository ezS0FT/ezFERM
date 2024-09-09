using System.Threading;
using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.SubActions
{
    public class Подзадача_2 : ISubAction
    {
        public WorkResult RunSubAction()
        {
            Thread.Sleep(0);
            return WorkResult.Удачно;
        }
    }
}