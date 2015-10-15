using AutoSandbox.Inputs.FuelSources;

namespace AutoSandbox.Inputs {
    /// <summary>
    /// Interface that exposes a contract of a type that can be filled with fuel.
    /// </summary>
    /// <typeparam name="TFuel">The type of <see cref="Fuel"/> this fillable instance accepts.</typeparam>
    public interface IFillable<in TFuel> where TFuel : Fuel {
        /// <summary>
        /// Method used to fill the given instance with the <typeparamref name="TFuel"/> type.
        /// </summary>
        /// <param name="fuel">The fuel the instance can be filled with.</param>
        /// <param name="request">The <see cref="FillRequest"/> used to specify filling details (such as rate, quantity / volume, etc...)</param>
        void Fill(TFuel fuel, FillRequest request);
    } // end interface IFillable
} // end namespace
