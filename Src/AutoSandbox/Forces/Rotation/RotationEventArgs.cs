using System;

namespace AutoSandbox.Forces.Rotation {
    /// <summary>
    /// EventArgument class that provides event details for rotation-related actions.
    /// </summary>
    [Serializable]
    public class RotationEventArgs : EventArgs {
        private RotationDirection _direction;

        /// <summary>
        /// Initializes a new instance of the <see cref="RotationEventArgs"/> class.  The default rotation direction is clockwise.
        /// </summary>
        public RotationEventArgs() : this(RotationDirection.Clockwise) {
        } // end default constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RotationEventArgs"/> class.
        /// </summary>
        /// <param name="direction">The direction of the rotation event.</param>
        public RotationEventArgs(RotationDirection direction) : base() {
            this._direction = direction;
        } // end overloaded constructor

        /// <summary>
        /// Gets the direction of the rotation.
        /// </summary>
        public RotationDirection Direction {
            get {
                return this._direction;
            } internal set {
                this._direction = value;
            }
        } // end property Direction
    } // end class RotationEventArgs
} // end namespace
