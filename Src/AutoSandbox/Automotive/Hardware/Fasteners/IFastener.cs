namespace AutoSandbox.Automotive.Hardware.Fasteners {
    /// <summary>
    /// Interface for a type of hardware used to fasten two objects together.
    /// </summary>
    public interface IFastener {
        /// <summary>
        /// Gets or sets the name of the fastener instance.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the current state of the fastener.
        /// </summary>
        FastenerState State { get; set; }
    } // end interface IFastener
} // end namespace
