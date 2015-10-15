using AutoSandbox.Materials;

namespace AutoSandbox.Inputs.FuelSources {
    /// <summary>
    /// Type that can be used as a source of fuel for another type that requires fuel to operate.  This class cannot be instantiated.
    /// </summary>
    public abstract class Fuel : IMaterial {
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fuel"/> class.
        /// </summary>
        protected Fuel() : this(string.Empty) {
        } // end default constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Fuel"/> class.
        /// </summary>
        /// <param name="name">The default name of the fuel.</param>
        protected Fuel(string name) {
            this._name = name;
        } // end overloaded constructor

        /// <summary>
        /// Gets the type of the material.
        /// </summary>
        public abstract MaterialType Material { get; }

        /// <summary>
        /// Gets or sets the name of the fuel.
        /// </summary>
        public virtual string Name {
            get {
                return this._name;
            } set {
                this._name = value;
            }
        } // end property Name
    } // end class Fuel
} // end namespace
