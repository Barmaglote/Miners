using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Code
{
    interface ILanguageChangable
    {
        void ChangeLanguage(Helpers.AvailableLocalizations localization);
    }
}
