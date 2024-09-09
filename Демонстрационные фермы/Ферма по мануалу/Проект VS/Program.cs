using ezFERM.Integraton;
using ZennoLab.CommandCenter;
using ZennoLab.InterfacesLibrary.ProjectModel;

namespace ZennoPosterProject1
{
    public class Program : IZennoExternalCode
    {
        //Метод Execute используется только при отладке VS проекта фермы через ProjectMaker.
        //Обязателен вызов метода ezFERM.Integraton.VSIntegration(), ezFERM начнет выполнение ваших задач и подзадач.;
        //ezFERM.API.API для доступа к нужным ресурсам фермы в ваших задачах и подзадачах.
        //ezFERM обращатеся к данной сборке для запуска задач и подзадач при выборе среды "Visual Studio" в настройках фермы.
        public int Execute(Instance instance, IZennoPosterProjectModel project)
        {
            VSIntegration.CreateAndRun(instance, project);
            return 0;
        }
    }
}