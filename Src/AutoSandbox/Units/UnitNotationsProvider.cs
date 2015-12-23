using System;
using System.Collections.Generic;

namespace AutoSandbox.Units {
    /// <summary>
    /// Provider class that provides common notations for measurements and other
    /// units in a readable form.
    /// </summary>
    public static class UnitNotationsProvider {
        private static bool _defaultsInitialized;
        private static Dictionary<LengthUnits, string> _lengthNotations;
        private static Dictionary<SpeedUnits, string> _speedNotations;
        private static Dictionary<TemperatureUnit, string> _temperatureNotations;
        private static Dictionary<Type, dynamic> _notations;

        /// <summary>
        /// Initializes static members of the <see cref="UnitNotationsProvider"/> class.
        /// </summary>
        static UnitNotationsProvider() {
            _defaultsInitialized = false;
            _lengthNotations = new Dictionary<LengthUnits, string>();
            _speedNotations = new Dictionary<SpeedUnits, string>();
            _temperatureNotations = new Dictionary<TemperatureUnit, string>();
            _notations = new Dictionary<Type, dynamic>();
            InitializeDefaults();
        } // end default static constructor

        /// <summary>
        /// Initializes the dictionaries with their respective default unit conversions.
        /// </summary>
        internal static void InitializeDefaults() {
            if (!_defaultsInitialized) { // Make the call safe so we don't have to check for duplicates all over the place
                InitializeLengthUnits();
                InitializeSpeedUnits();
                _notations.Add(typeof(SpeedUnits), _speedNotations as dynamic);
                _notations.Add(typeof(LengthUnits), _lengthNotations as dynamic);
                _notations.Add(typeof(TemperatureUnit), _temperatureNotations as dynamic);
                _defaultsInitialized = true;
            }
        } // end method InitializeDefaults

        /// <summary>
        /// Populates the length unit dictionary with known values.
        /// </summary>
        internal static void InitializeLengthUnits() {
            _lengthNotations.Add(LengthUnits.Centimeters, "cm");
            _lengthNotations.Add(LengthUnits.Feet, "ft");
            _lengthNotations.Add(LengthUnits.Inches, "in");
            _lengthNotations.Add(LengthUnits.Kilometers, "km");
            _lengthNotations.Add(LengthUnits.Meters, "m");
            _lengthNotations.Add(LengthUnits.Miles, "mi");
            _lengthNotations.Add(LengthUnits.Millimeters, "mm");
            _lengthNotations.Add(LengthUnits.NauticalMiles, "nmi");
            _lengthNotations.Add(LengthUnits.Yards, "yd");
        } // end method InitializeLengthUnits
         
        /// <summary>
        /// Populates the speed unit dictionary with known values.
        /// </summary>
        internal static void InitializeSpeedUnits() {
            _speedNotations.Add(SpeedUnits.FeetPerSecond, "ft/s");
            _speedNotations.Add(SpeedUnits.KilometersPerHour, "km/h");
            _speedNotations.Add(SpeedUnits.Knots, "kn");
            _speedNotations.Add(SpeedUnits.MetersPerSecond, "m/s");
            _speedNotations.Add(SpeedUnits.MilesPerHour, "mph");
            _speedNotations.Add(SpeedUnits.RotationsPerMinute, "RPM");
        } // end method InitializeSpeedUnits

        /// <summary>
        /// Populates the temperature unit dictionary with known values.
        /// </summary>
        internal static void InitializeTemperatureUnits() {
            _temperatureNotations.Add(TemperatureUnit.Celsius, "C");
            _temperatureNotations.Add(TemperatureUnit.Fahrenheit, "F");
            _temperatureNotations.Add(TemperatureUnit.Kelvin, "K");
            _temperatureNotations.Add(TemperatureUnit.Newton, "N");
        } // end method InitializeSpeedUnits

        /// <summary>
        /// Returns the common notation for a given length <paramref name="unit"/> of measure.
        /// </summary>
        /// <param name="unit">The unit whose notation is being looked-up.</param>
        /// <returns>The common notation for the given unit.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the given <paramref name="unit"/> is not found / known.</exception>
        public static string LengthNotation(LengthUnits unit) {
            string returnValue = string.Empty;

            if (_lengthNotations.ContainsKey(unit)) {
                returnValue = _lengthNotations[unit];
            } else {
                throw new KeyNotFoundException("Unknown unit of length: " + unit.ToString());
            }

            return returnValue;
        } // end function LengthNotation

        /// <summary>
        /// Returns the common notation for a given speed <paramref name="unit"/> of measure.
        /// </summary>
        /// <param name="unit">The unit whose notation is being looked-up.</param>
        /// <returns>The common notation for the given unit.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the given <paramref name="unit"/> is not found / known.</exception>
        public static string SpeedNotation(SpeedUnits unit) {
            string returnValue = string.Empty;

            if (_speedNotations.ContainsKey(unit)) {
                returnValue = _speedNotations[unit];
            } else {
                throw new KeyNotFoundException("Unknown unit of speed: " + unit.ToString());
            }

            return returnValue;
        } // end function SpeedNotation

        /// <summary>
        /// Returns the common notation for a given temperature <paramref name="unit"/> of measure.
        /// </summary>
        /// <param name="unit">The unit whose notation is being looked-up.</param>
        /// <returns>The common notation for the given unit.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the given <paramref name="unit"/> is not found / known.</exception>
        public static string TemperatureNotation(TemperatureUnit unit) {
            string returnValue = string.Empty;

            if (_temperatureNotations.ContainsKey(unit)) {
                returnValue = _temperatureNotations[unit];
            } else {
                throw new KeyNotFoundException("Unknown unit of speed: " + unit.ToString());
            }

            return returnValue;
        } // end function TemperatureNotation

        /// <summary>
        /// Returns the common notation for a given <paramref name="unit"/> of measure.
        /// </summary>
        /// <typeparam name="TUnit">The type of unit to look-up</typeparam>
        /// <param name="unit">The unit whose notation is being looked-up.</param>
        /// <returns>The common notation for the given unit.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the given <paramref name="unit"/> is not found / known.</exception>
        public static string GetNotation<TUnit>(TUnit unit) where TUnit : struct {
            string returnValue = string.Empty;

            if (_notations.ContainsKey(typeof(TUnit))) {
                dynamic list = _notations[typeof(TUnit)];

                if (list.ContainsKey(unit)) {
                    returnValue = list[unit];
                } else {
                    throw new KeyNotFoundException("Unknown unit: " + unit.ToString());
                }
            } else {
                throw new KeyNotFoundException("Unknown unit type: " + typeof(TUnit).ToString());
            }

            return returnValue;
        } // end function GetNotation
    } // end class UnitNotationsProvider
} // end namespace
