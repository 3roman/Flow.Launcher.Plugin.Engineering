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

            if (0 == string.Compare("pt97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double p);
                _ = double.TryParse(query.SecondSearch, out double t);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PT2V(p, t) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2H(p, t) + string.Empty,
                        SubTitle = "Specific Enthalpy (h)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2S(p, t) + string.Empty,
                        SubTitle = "Specific Entropy (s)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2EX(p, t)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PT2CP(p, t) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2CV(p, t) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PT2KS(p, t) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
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
                        Title = IF97.PT2W(p, t) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.PT2DV(p, t) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
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
            else if (0 == string.Compare("px97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double p);
                _ = double.TryParse(query.SecondSearch, out double x);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PX2T(p, x) + string.Empty,
                        SubTitle = "Temperature (t)    [℃]",
                    },
                    new Result
                    {
                        Title = IF97.PX2V(p, x) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2H(p, x) + string.Empty,
                        SubTitle = "Specific Enthalpy (h)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2S(p, x) + string.Empty,
                         SubTitle = "Specific Entropy (s)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2EX(p, x)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PX2CP(p, x) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2CV(p, x) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PX2KS(p, x) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
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
                        Title = IF97.PX2W(p, x) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.PX2DV(p, x) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.PX2R(p, x) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }
            else if (0 == string.Compare("tx97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double t);
                _ = double.TryParse(query.SecondSearch, out double x);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.TX2P(t, x) + string.Empty,
                        SubTitle = "Pressure (p)  [bara]",
                    },
                    new Result
                    {
                        Title = IF97.TX2V(t, x) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.TX2H(t, x) + string.Empty,
                        SubTitle = "Specific Enthalpy (h)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.TX2S(t, x) + string.Empty,
                         SubTitle = "Specific Entropy (s)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.TX2EX(t, x)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.TX2CP(t, x) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.TX2CV(t, x) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.TX2KS(t, x) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.TX2Z(t, x) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.TX2JTC(t, x) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.TX2W(t, x) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.TX2DV(t, x) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.TX2R(t, x) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }
            else if (0 == string.Compare("ph97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double p);
                _ = double.TryParse(query.SecondSearch, out double h);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PH2T(p, h) + string.Empty,
                        SubTitle = "Temperature (t)    [℃]",
                    },
                    new Result
                    {
                        Title = IF97.PH2V(p, h) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PH2S(p, h) + string.Empty,
                         SubTitle = "Specific Entropy (s)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PH2EX(p, h)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PH2CP(p, h) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PH2CV(p, h) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PH2KS(p, h) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.PH2Z(p, h) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.PH2JTC(p, h) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.PH2W(p, h) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.PH2DV(p, h) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.PH2X(p, h) + string.Empty,
                        SubTitle = "Steam Quality (X)",
                    },
                    new Result
                    {
                        Title = IF97.PH2R(p, h) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }
            else if (0 == string.Compare("ps97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double p);
                _ = double.TryParse(query.SecondSearch, out double s);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.PS2T(p, s) + string.Empty,
                        SubTitle = "Temperature (t)    [℃]",
                    },
                    new Result
                    {
                        Title = IF97.PS2V(p, s) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PS2H(p, s) + string.Empty,
                         SubTitle = "Specific Enthalpy (h)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PS2EX(p, s)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.PS2CP(p, s) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PS2CV(p, s) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.PS2KS(p, s) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.PS2Z(p, s) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.PS2JTC(p, s) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.PS2W(p, s) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.PS2DV(p, s) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.PS2X(p, s) + string.Empty,
                        SubTitle = "Steam Quality (X)",
                    },
                    new Result
                    {
                        Title = IF97.PS2R(p, s) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }
            else if (0 == string.Compare("hs97", query.ActionKeyword) && 2 == query.SearchTerms.Length)
            {
                _ = double.TryParse(query.FirstSearch, out double h);
                _ = double.TryParse(query.SecondSearch, out double s);

                results = new List<Result>
                {
                    new Result
                    {
                        Title = IF97.HS2P(h, s) + string.Empty,
                        SubTitle = "Pressure (p)   [bara]",
                    },
                    new Result
                    {
                        Title = IF97.HS2T(h, s) + string.Empty,
                        SubTitle = "Temperature (t)    [℃]",
                    },

                    new Result
                    {
                        Title = IF97.HS2V(h, s) + string.Empty,
                        SubTitle = "Specific Volume (v)   [m³/kg]",
                    },
                    new Result
                    {
                        Title = IF97.HS2EX(h, s)  + string.Empty,
                        SubTitle = "Specific Exergy (ex)   [kJ/kg]",
                    },
                    new Result
                    {
                        Title = IF97.HS2CP(h, s) + string.Empty,
                        SubTitle = "Specific Isobaric Heat Capacity (cp)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.HS2CV(h, s) + string.Empty,
                        SubTitle = "Specific Isochoric  Heat Capacity (cv)   [kJ/(kg.℃)]",
                    },
                    new Result
                    {
                        Title = IF97.HS2KS(h, s) + string.Empty,
                        SubTitle = "Isentropic Exponent (KS)",
                    },
                    new Result
                    {
                        Title = IF97.HS2Z(h, s) + string.Empty,
                        SubTitle = "Compressibility Factor (Z)",
                    },
                    new Result
                    {
                        Title = IF97.HS2JTC(h, s) + string.Empty,
                        SubTitle = "Joule-Thomson Coefficient (JTC)",
                    },
                    new Result
                    {
                        Title = IF97.HS2W(h, s) + string.Empty,
                        SubTitle = "Speed of Sound (W)  [m/s]",
                    },
                    new Result
                    {
                        Title = IF97.HS2DV(h, s) * 1E3 + string.Empty,
                        SubTitle = "Dynamic Viscosity (dv)   [cp]",
                    },
                    new Result
                    {
                        Title = IF97.HS2X(h, s) + string.Empty,
                        SubTitle = "Steam Quality (X)",
                    },
                    new Result
                    {
                        Title = IF97.HS2R(h, s) + string.Empty,
                        SubTitle = "Region (R)",
                    },
                };
            }

            results.ForEach(item =>
            {
                item.CopyText = item.Title;
            });

            return results;
        }
    }
}
