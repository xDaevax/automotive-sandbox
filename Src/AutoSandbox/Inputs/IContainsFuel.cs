namespace AutoSandbox.Inputs {
    /// <summary>
    /// Interface for a type that can contain fuel.
    /// </summary>
    public interface IContainsFuel {
        /// <summary>
        /// Gets or sets the capacity of the fuel container.
        /// </summary>
        double Capacity { get; set; }
    } // end interface IContainsFuel
} // end namespace
