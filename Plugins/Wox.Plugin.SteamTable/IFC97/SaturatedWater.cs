namespace Wox.Plugin.SteamTable.IFC97
{
    public class SaturatedWater : H2O
    {
        public SaturatedWater(double saturatedPressure)
        {
            Pressure = saturatedPressure;
            IFC97Wrapper.P2T97(Pressure, ref _temperature, ref _region);
            IFC97Wrapper.P2HL97(Pressure, ref _enthalpy, ref _region);
            IFC97Wrapper.P2SL97(Pressure, ref _entropy, ref _region);
            IFC97Wrapper.P2VL97(Pressure, ref _specificVolume, ref _region);
            IFC97Wrapper.P2KSL97(Pressure, ref _isentropicIndex, ref _region);
            IFC97Wrapper.P2ETAL97(Pressure, ref _dynamiViscosity, ref _region);
        }
    }
}
