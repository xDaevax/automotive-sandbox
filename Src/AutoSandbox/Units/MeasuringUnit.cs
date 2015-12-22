namespace AutoSandbox.Units {
    /// <summary>
    /// Structure that stores a value and a unit of measure.
    /// </summary>
    /// <typeparam name="TValue">The type of value being stored by the measurement.</typeparam>
    /// <typeparam name="TUnit">The type of unit being stored by the measurement.</typeparam>
    public struct MeasuringUnit<TValue, TUnit> where TValue : struct where TUnit : struct {
        /// <summary>
        /// The value of the measurement
        /// </summary>
        public TValue Value;

        /// <summary>
        /// The unit of measurement
        /// </summary>
        public TUnit Unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasuringUnit{TValue, TUnit}"/> structure.
        /// </summary>
        /// <param name="value">The value of the measurement</param>
        /// <param name="unit">The unit of measure</param>
        public MeasuringUnit(TValue value, TUnit unit) {
            this.Value = value;
            this.Unit = unit;
        } // end default structure constructor

        /// <summary>
        /// Returns the common notation for the unit of measurement.
        /// </summary>
        /// <returns>A string representation of the unit notation.</returns>
        public string Notation() {
            return UnitNotationsProvider.GetNotation<TUnit>(this.Unit);
        } // end function Notation
    } // end structure MeasuringUnit
} // end namespace
