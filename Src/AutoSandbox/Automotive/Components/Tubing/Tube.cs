namespace AutoSandbox.Automotive.Components.Tubing {
    /// <summary>
    /// Base type that defines basic properties of a type that is typically cylindrical and used
    /// either as a mechanism to contain lengths or transport certain types of materials
    /// that consume the volume of the tube.
    /// </summary>
    public abstract class Tube {
        private double _diameter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tube"/> class.
        /// </summary>
        protected Tube() {
            this._diameter = 0D;
        } // end default constructor
         
        /// <summary>
        /// Gets or sets the diameter of the tube.
        /// </summary>
        public virtual double Diamater {
            get {
                return this._diameter;
            } set {
                this._diameter = value;
            }
        } // end property Diameter
    } // end class Tube
} // end namespace
