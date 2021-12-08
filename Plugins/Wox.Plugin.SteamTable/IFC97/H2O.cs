namespace Wox.Plugin.SteamTable.IFC97
{
    public abstract class H2O
    {
        // MPag
        protected double _pressure;

        public double Pressure
        {
            get { return _pressure; }
            protected set { _pressure = value; }
        }

        // ℃
        protected double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            protected set { _temperature = value; }
        }

        // kJ/kg
        protected double _enthalpy;

        public double Enthalpy
        {
            get { return _enthalpy; }
        }

        // kJ/(kg.℃)
        protected double _entropy;

        public double Entropy
        {
            get { return _entropy; }
        }

        // m³/kg
        protected double _specificVolume;

        public double SpecificVolume
        {
            get { return _specificVolume; }
        }

        protected double _isentropicIndex;

        public double IsentropicIndex
        {
            get { return _isentropicIndex; }
        }

        // cp
        protected double _dynamiViscosity;

        public double DynamiViscosity
        {
            get { return _dynamiViscosity * 1e3; }
        }

        protected int _region;

        public int Region
        {
            get { return _region; }
        }
    }
}
