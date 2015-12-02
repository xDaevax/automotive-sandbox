namespace AutoSandbox.Materials {
    /// <summary>
    /// Interface that exposes behavior for types that are capable of undergoing combustion.
    /// </summary>
    public interface ICombustible {
        /// <summary>
        /// Gets or sets the current temperature of the combustible.
        /// </summary>
        Temperature CurrentTemperature { get; set; }

        /// <summary>
        /// Gets the point at which this instance can begin combustion.
        /// </summary>
        Temperature CombustionPoint { get; }
    } // end interface ICombustible
} // end namespace
