namespace Wox.Plugin.SteamTable.IFC97
{
    public class SaturatedWater : H2O
    {
        public SaturatedWater(double param, bool isPressure = true)
        {
            if (isPressure)
            {
                Pressure = param;
                IFC97Wrapper.P2T97(Pressure, ref _temperature, ref _region);
                IFC97Wrapper.P2HL97(Pressure, ref _enthalpy, ref _region);
                IFC97Wrapper.P2SL97(Pressure, ref _entropy, ref _region);
                IFC97Wrapper.P2VL97(Pressure, ref _specificVolume, ref _region);
                IFC97Wrapper.P2KSL97(Pressure, ref _isentropicIndex, ref _region);
                IFC97Wrapper.P2ETAL97(Pressure, ref _dynamiViscosity, ref _region);
            }
            else
            {
                Temperature = param;
                IFC97Wrapper.T2P97(Temperature, ref _pressure, ref _region);
                IFC97Wrapper.T2HL97(Temperature, ref _enthalpy, ref _region);
                IFC97Wrapper.T2SL97(Temperature, ref _entropy, ref _region);
                IFC97Wrapper.T2VL97(Temperature, ref _specificVolume, ref _region);
                IFC97Wrapper.T2KSL97(Temperature, ref _isentropicIndex, ref _region);
                IFC97Wrapper.T2ETAL97(Temperature, ref _dynamiViscosity, ref _region);
            }
        }
    }
}
