using System.Collections.Generic;

namespace Flow.Launcher.Plugin.Engineering.IAPWS_IF97
{
    public class Main : IPlugin
    {
        public void Init(PluginInitContext context)
        {
            //throw new NotImplementedException();
        }

        public List<Result> Query(Query query)
        {
            List<Result> results = new List<Result>();

            if (0 == string.Compare("pt", query.FirstSearch, true) && 3 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.SecondSearch, out double p);
                _ = double.TryParse(query.ThirdSearch, out double t);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PT2H(p, t) + string.Empty,
                        SubTitle = "Specific Enthalpy (H)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2S(p, t) + string.Empty,
                        SubTitle = "Specific Entropy (S)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2V(p, t) + string.Empty,
                        SubTitle = "Specific Volume (V)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2CP(p, t) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (CP)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2CV(p, t) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (CV)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2DV(p, t) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (DV)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.PT2KS(p, t) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.PT2E(p, t)  + string.Empty,
                        SubTitle = "Specific Exergy (E)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2Z(p, t) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.PT2JTC(p, t) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.PT2X(p, t) + string.Empty,
                        SubTitle = "Steam Quality (X)",
                    },
                    new Result
                    {
                        Title = IF97.PT2R(p, t) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }
            else if (0 == string.Compare("px", query.FirstSearch, true) && 3 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.SecondSearch, out double p);
                _ = double.TryParse(query.ThirdSearch, out double x);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PX2T(p, x) + string.Empty,
                        SubTitle = "T  [℃]",
                    },
                    new Result
                    {
                        Title = IF97.PX2H(p, x) + string.Empty,
                        SubTitle = "Specific Enthalpy (H)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2S(p, x) + string.Empty,
                         SubTitle = "Specific Entropy (S)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2V(p, x) + string.Empty,
                        SubTitle = "Specific Volume (V)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2CP(p, x) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (CP)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2CV(p, x) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (CV)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2DV(p, x) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (DV)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.PX2KS(p, x) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.PX2E(p, x)  + string.Empty,
                        SubTitle = "Specific Exergy (E)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2Z(p, x) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.PX2JTC(p, x) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.PX2R(p, x) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }

            results.ForEach(item => item.Action =
                    _ =>
                    {
                        System.Windows.Clipboard.SetDataObject(item.Title);
                        return false;
                    }
                 );

            return results;
        }
    }
}
