﻿using System;
using Newtonsoft.Json;
using QPdfNet.Enums;

namespace QPdfNet
{
    /// <summary>
    ///     The encryption settings
    /// </summary>
    internal class Encryption
    {
        #region Fields
        /// <summary>
        ///     The encryption options
        /// </summary>
        [JsonProperty("40bit")]
        private EncryptionOptions _options40;

        [JsonProperty("128bit")]
        private EncryptionOptions _options128;

        [JsonProperty("256bit")]
        private EncryptionOptions _options256;
        #endregion

        #region Properties
        /// <summary>
        ///     The user password
        /// </summary>
        [JsonProperty("userPassword")]
        public string UserPassword { get; private set; }

        /// <summary>
        ///     The owner password
        /// </summary>
        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; private set; }

        [JsonIgnore]
        public EncryptionOptions Options;
        #endregion

        #region Constructor
        /// <summary>
        ///     Makes this object and sets its needed properties
        /// </summary>
        /// <param name="userPassword">The user password</param>
        /// <param name="ownerPassword">The owner password</param>
        /// <param name="options"><see cref="EncryptionOptions"/></param>
        internal Encryption(
            string userPassword, 
            string ownerPassword, 
            EncryptionOptions options)
        {
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;

            switch (options.GetType().Name)
            {
                case "Encryption40bit":
                    _options40 = options;
                    Options = _options40;
                    break;

                case "Encryption128bit":
                    _options128 = options;
                    Options = _options40;
                    break;

                case "Encryption256bit":
                    _options256 = options;
                    Options = _options40;
                    break;

                default:
                    throw new ArgumentException(
                        "User either the class Encryption40Bit, Encryption128Bit or Encryption256Bit");
            }
        }
        #endregion
    }
}
