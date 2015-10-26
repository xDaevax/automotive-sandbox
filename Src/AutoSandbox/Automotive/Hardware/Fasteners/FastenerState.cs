using System;

namespace AutoSandbox.Automotive.Hardware.Fasteners {
    /// <summary>
    /// Enumeration for different potential states a fastener can be in.
    /// </summary>
    [Serializable]
    public enum FastenerState : int {
        /// <summary>
        /// The fastener is not fastened at all.
        /// </summary>
        Unfastened = 0,

        /// <summary>
        /// The fastener is fastening two objects, but the amount of force required to unfasten it is very small.
        /// </summary>
        VeryLoose = 1,

        /// <summary>
        /// The fastener is holding, but over prolonged periods it is possible the fastener could become loose.  It is
        /// possible that the fastener is causing damage or being damaged.
        /// </summary>
        Loose = 2,

        /// <summary>
        /// The fastener is well-attached an during normal operation will be unlikely to loosen-up.
        /// </summary>
        Snug = 3,

        /// <summary>
        /// The fastener is properly and securely attached.  The items being fastened will not become unfastened
        /// unless the fastener itself fails due to abnormal operating circumstances.
        /// </summary>
        Fastened = 4,

        /// <summary>
        /// The fastener has been tightened beyond what was necessary and is likely causing damage or being damaged.
        /// </summary>
        OverTightend = 5
    } // end enumeration FastenerState
} // end namespace
