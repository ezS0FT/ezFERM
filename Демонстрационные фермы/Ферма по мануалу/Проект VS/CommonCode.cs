using System.Collections.Generic;
using System.Linq;
using ZennoLab.InterfacesLibrary.ProjectModel;
using static ezFERM.API.API;

namespace ZennoPosterProject1
{
    internal static class CommonCode
    {
        public static int RowNumber(string tableName)
        {
            IZennoTable zpTable = Project.Tables[tableName];
            List<string> accNames = zpTable.GetColumn("A").ToList();
            return accNames.IndexOf(Project.Variables["sys_profile_name"].Value);
        }
    }
}
