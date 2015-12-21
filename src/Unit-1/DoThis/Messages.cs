using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{
    public class Messages
    {
        #region Neutral/system messages
        /// <summary>Marker class to continue processing.</summary>
        public class ContinueProcessing { }
        #endregion

        #region Success messages
        /// <summary>Base class for signalling that user input was valid.</summary>
        public class InputSuccess
        {
            public string Reason { get; private set; }
            /// <summary>
            /// Initializes a new instance of the <see cref="InputSuccess"/> class.
            /// </summary>
            /// <param name="reason"></param>
            public InputSuccess(string reason)
            {
                Reason = reason;
            }
        }
        #endregion

        #region Error messages
        /// <summary>Base class for signalling that user input was invalid.</summary>
        public class InputError
        {
            public string Reason { get; private set; }
            /// <summary>
            /// Initializes a new instance of the <see cref="InputError"/> class.
            /// </summary>
            /// <param name="reason"></param>
            public InputError(string reason)
            {
                Reason = reason;
            }
        }

        /// <summary>User provided blank input.</summary>
        public class NullInputError : InputError
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="NullInputError"/> class.
            /// </summary>
            public NullInputError(string reason) : base(reason) { }
        }

        /// <summary>User provided invalid input (currently, input w. odd # chars)</summary>
        public class ValidationError : InputError
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ValidationError"/> class.
            /// </summary>
            public ValidationError(string reason) : base(reason) { }
        }
        #endregion
    }
}
