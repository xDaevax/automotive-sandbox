using AutoSandbox.Materials;
using AutoSandbox.Units;

namespace AutoSandbox.Automotive.Components.Tubing {
    /// <summary>
    /// Base type that defines basic properties of a type that is typically cylindrical and used
    /// either as a mechanism to contain lengths or transport certain types of materials
    /// that consume the volume of the tube.
    /// </summary>
    public abstract class Tube : IMaterial {
        private MeasuringUnit<double, LengthUnits> _diameter;
        private MeasuringUnit<double, LengthUnits> _length;
        private MaterialType _material;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tube"/> class.
        /// </summary>
        protected Tube() {
            this._diameter.Value = 0D;
            this._diameter.Unit = LengthUnits.Centimeters;
            this._length.Value = 1D;
            this._length.Unit = LengthUnits.Inches;
        } // end default constructor
         
        /// <summary>
        /// Gets or sets the diameter of the tube.
        /// </summary>
        public virtual MeasuringUnit<double, LengthUnits> Diamater {
            get {
                return this._diameter;
            } set {
                this._diameter = value;
            }
        } // end property Diameter

        /// <summary>
        /// Gets or sets the length of the tube.
        /// </summary>
        public virtual MeasuringUnit<double, LengthUnits> Length {
            get {
                return this._length;
            } set {
                this._length = value;
            }
        } // end property Length

        /// <summary>
        /// Gets the type of the material the tube is made of.
        /// </summary>
        public abstract MaterialType Material { get; }
    } // end class Tube
} // end namespace
