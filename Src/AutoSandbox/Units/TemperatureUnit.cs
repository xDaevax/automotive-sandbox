namespace AutoSandbox.Units {
    /// <summary>
    /// Enumeration that contains possible values for units used when measuring temperature.  This type is primarily used for computation,
    /// but can also be used for rendering units for display / output.
    /// </summary>
    public enum TemperatureUnit : int {
        /// <summary>
        /// Indicates a temperature represented on the Fahrenheit scale (32 - Freezing, 212 - Boiling).
        /// </summary>
        Fahrenheit = 0,

        /// <summary>
        /// Indicates a temperature represented on the Celsius scale (0 - Freezing - 100 Boiling).
        /// </summary>
        Celsius = 1,

        /// <summary>
        /// Indicates a temperature represented on the Kelvin scale.
        /// </summary>
        Kelvin = 2,

        /// <summary>
        /// Indicates a temperature represented on the Newton scale.
        /// </summary>
        Newton = 3
    } // end enumeration TemperatureUnit
} // end namespace
