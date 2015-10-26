namespace AutoSandbox.Automotive.Hardware.Fasteners {
    /// <summary>
    /// Type that exposes a basic implementation for a clamp fastener capable of clamping two or more objects together.
    /// </summary>
    public abstract class Clamp : IFastener {
        private string _name;
        private FastenerState _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Clamp"/> class.
        /// </summary>
        protected Clamp() {
            this._name = string.Empty;
            this._state = FastenerState.Unfastened;
        } // end default constructor
         
        /// <summary>
        /// Gets or sets the name of the fastener instance.
        /// </summary>
        public string Name {
            get {
                return this._name;
            } set {
                this._name = value;
            }
        } // end property Name

        /// <summary>
        /// Gets or sets a value indicating the current state of the fastener.
        /// </summary>
        public FastenerState State {
            get {
                return this._state;
            } set {
                this._state = value;
            }
        } // end property State
    } // end class Clamp
} // end namespace
