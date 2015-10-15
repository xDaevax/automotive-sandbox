namespace AutoSandbox.Materials {
    /// <summary>
    /// Enumeration that defines potential values for a material.  Material and material types are used in many different places to control properties of a type
    /// and how that type can be used in certain events or transactions.
    /// </summary>
    public enum MaterialType : int {
        /// <summary>
        /// Unspecified material.  Generally, this should not be used.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// The material is a liquid and could be used in operations where liquid is required (filling fuel, lubricants, etc...).
        /// </summary>
        Liquid = 1,

        /// <summary>
        /// The material is a gas and could be used in operations where gas is needed (exhaust, oxygen input, etc...).
        /// </summary>
        Gas = 2,

        /// <summary>
        /// The material is a solid and could be used in operations where solids are needed (brake pads, wires, etc...).
        /// </summary>
        Solid = 3
    } // end enumeration MaterialType
} // end namespace
