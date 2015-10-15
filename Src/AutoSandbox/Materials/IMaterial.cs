namespace AutoSandbox.Materials {
    /// <summary>
    /// Interface that exposes a contract for a type that is used as a material.  Technically, most concrete things (car, brakes, windshield) are materials.
    /// This interface is intended more for types that need to be of a specific type of material in order to be used in a certain application.  If the type
    /// you are creating is not application or use specific, there is no need to implement this interface type.
    /// </summary>
    public interface IMaterial {
        /// <summary>
        /// Gets the type of the material.
        /// </summary>
        MaterialType Material { get; }
    } // end interface IMaterial
} // end namespace
