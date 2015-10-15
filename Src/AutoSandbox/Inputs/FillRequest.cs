using System;
using AutoSandbox.Inputs.FuelSources;

namespace AutoSandbox.Inputs {
    /// <summary>
    /// Base type that can be extended and used as a unit of work model 
    /// </summary>
    public abstract class FillRequest {
        private readonly Fuel _fuel;

        /// <summary>
        /// Prevents a default instance of the <see cref="FillRequest"/> class from being created.
        /// </summary>
        private FillRequest() : this(null) {
        } // end default constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FillRequest"/> class.
        /// </summary>
        /// <param name="fuel">The fuel that this request will fill.</param>
        /// <exception cref="ArgumentNullException">Thrown if the given <paramref name="fuel"/> is null.</exception>
        protected FillRequest(Fuel fuel) {
            if (object.Equals(null, fuel)) {
                throw new ArgumentNullException(nameof(fuel), "No fuel provided for the fill request.");
            }

            this._fuel = fuel;
        } // end overloaded constructor

        /// <summary>
        /// Gets the fuel that this request will fill.
        /// </summary>
        protected Fuel Fuel {
            get {
                return this._fuel;
            }
        } // end property Fuel
    } // end class FillRequest
} // end namespace
