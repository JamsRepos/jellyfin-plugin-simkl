﻿using System.Text.Json.Serialization;
#pragma warning disable SA1300

namespace Jellyfin.Plugin.Simkl.API.Responses
{
    /// <summary>
    /// Code status response.
    /// </summary>
    public class CodeStatusResponse
    {
        /// <summary>
        /// Gets or sets result.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets access token.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }
    }
}
