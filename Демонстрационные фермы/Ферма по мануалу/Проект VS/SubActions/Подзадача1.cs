using LISA_Core.Interfaces;
using static LISA_Core.Core.ServiseBase;

namespace ZennoPosterProject1.SubActions
{
    public class Подзадача1 : ISubAction
    {
        // Имя подзадачи = имя класса.
        // Строки кода вашей подзадачи внутри тела метода RunSubAction().
        public WorkResult RunSubAction()
        {
            return WorkResult.Удачно;
        }
    }
}