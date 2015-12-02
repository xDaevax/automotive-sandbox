using AutoSandbox.Units;

namespace AutoSandbox.Materials {
    /// <summary>
    /// Class used to represent a temperature.  This class has many uses(ex: Combustion, freedom of rotation, viscosity, pressure, etc...).
    /// </summary>
    public class Temperature {
        private double _temperatureValue;
        private TemperatureUnit _scale;

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials.Temperature"/> class.
        /// </summary>
        public Temperature() : this(0D) {
        } // end default constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials.Temperature"/> class.
        /// </summary>
        /// <param name="temperature">The numeric value representing the current temperature.</param>
        public Temperature(double temperature) : this(temperature, TemperatureUnit.Fahrenheit) {
        } // end overloaded constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials.Temperature"/> class.
        /// </summary>
        /// <param name="temperature">The numeric value representing the current temperature.</param>
        /// <param name="scale">The scale used for the temperature.</param>
        public Temperature(double temperature, TemperatureUnit scale) {
            this._scale = scale;
            this._temperatureValue = temperature;
        } // end overloaded constructor

        /// <summary>
        /// Gets the numeric temperature.
        /// </summary>
        public double TemperatureValue {
            get {
                return this._temperatureValue;
            }
        } // end property TemperatureValue

        /// <summary>
        /// Gets the scale used for measuring the temperature.
        /// </summary>
        public TemperatureUnit Scale {
            get {
                return this._scale;
            }
        } // end property Scale
    } // end class Temperature
} // end namespace
