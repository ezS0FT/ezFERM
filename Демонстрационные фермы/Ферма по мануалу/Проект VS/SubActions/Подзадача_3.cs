using System.Threading;
using ezFERM.Interfaces;
using static ezFERM.Settings.PMSettings;
using static ezFERM.API.API;

namespace ZennoPosterProject1.SubActions
{
    public class Подзадача_3 : ISubAction
    {
        public WorkResult RunSubAction()
        {
            Thread.Sleep(0);
            return WorkResult.Удачно;
        }
    }
}