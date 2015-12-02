namespace AutoSandbox.Units {
    /// <summary>
    /// Enumeration that contains possible values for units used when measuring different types of speed.  This type is primarily used for computation,
    /// but can also be used for rendering units for display / output.
    /// </summary>
    public enum SpeedUnits : int {
        /// <summary>
        /// No Speed unit specified.  This value is provided as a default.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Represents a unit of speed measured by miles traveled in 1 hour.
        /// </summary>
        MilesPerHour = 1,

        /// <summary>
        /// Represents a unit of speed measured by the number of kilometers traveled in 1 hour.
        /// </summary>
        KilometersPerHour = 2,

        /// <summary>
        /// Represents a unit of speed measured by the number of nautical miles traveled in 1 hour.  This is roughly 1.151 MPH or 1.852 KPH.
        /// </summary>
        Knots = 3,

        /// <summary>
        /// Represents a unit of speed measured by the number of rotations that occur in 1 minute (often abbreviated RPM).
        /// </summary>
        RotationsPerMinute = 4,

        /// <summary>
        /// Represents a unit of speed measured by feet traveled in 1 second.
        /// </summary>
        FeetPerSecond = 5,

        /// <summary>
        /// Represents a unit of speed measured by meters traveled in 1 second.
        /// </summary>
        MetersPerSecond = 6
    } // end enumeration SpeedUnits
} // end namespace
