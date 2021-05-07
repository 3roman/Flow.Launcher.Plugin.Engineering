using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Wox.Plugin.SteamTable
{
    public class SteamTable : IPlugin, IPluginI18n
    {
        private PluginInitContext _context;

        public string GetLanguagesFolder()
        {
            return null;
        }

        public string GetTranslatedPluginTitle()
        {
            return _context.API.GetTranslation("wox_plugin_title");
        }

        public string GetTranslatedPluginDescription()
        {
            return _context.API.GetTranslation("wox_plugin_description");
        }

        public void Init(PluginInitContext context) 
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            var parameters = query.Search.Split();
            if (2 == parameters.Length)
            {
                double press = Convert.ToDouble(parameters[0]);
                double temp = Convert.ToDouble(parameters[1]);
                return PT(press, temp);
            }

            return null;
        }

        private List<Result> PT(double press, double temp)
        {
            double h = 0, s = 0, v = 0, eta = 0, k = 0;
            int r = 0;
            try
            {
                Wrapper.PT2H97(press, temp, ref h, ref r);
                Wrapper.PT2S97(press, temp, ref s, ref r);
                Wrapper.PT2V97(press, temp, ref v, ref r);
                Wrapper.PT2KS97(press, temp, ref k, ref r);
                Wrapper.PT2ETA97(press, temp, ref eta, ref r);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return new List<Result>
            {
                new Result
                {
                    Title = h + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_enthalpy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(h + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = s + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_entropy"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(s+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = v + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_specific_volume"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(v+ string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = (1/v) + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_density"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject((1/v) + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = k + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_isentropic_index"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(k + string.Empty);
                        return true;
                    }
                },
                new Result
                {
                    Title = eta*1000 + string.Empty,
                    SubTitle = _context?.API.GetTranslation("wox_plugin_result_dynamic_viscosity"),
                    IcoPath = "Images\\item.png",
                    Action = _ =>
                    {
                        Clipboard.SetDataObject(eta*1000 + string.Empty);
                        return true;
                    }
                },

            };
        }
    }
}
