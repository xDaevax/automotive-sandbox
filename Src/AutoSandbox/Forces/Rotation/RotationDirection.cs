using System;

namespace AutoSandbox.Forces.Rotation {
    /// <summary>
    /// Enumeration that defines available options for rotational forces.
    /// </summary>
    [Serializable]
    public enum RotationDirection : int {
        /// <summary>
        /// Indicates a rotation direction moving clockwise.
        /// </summary>
        Clockwise = 0,

        /// <summary>
        /// Indicates a rotation direction moving counter-clockwise.
        /// </summary>
        CounterClockwise = 1
    } // end enumeration RotationDirection
} // end namespace
