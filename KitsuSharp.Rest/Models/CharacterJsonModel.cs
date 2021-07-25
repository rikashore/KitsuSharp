﻿using Newtonsoft.Json;

namespace KitsuSharp.Rest.Models
{
    public class CharacterJsonModel : ResourceBaseJsonModel
    {
        public static readonly string Type = "characters";

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("malId")]
        public int MalId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public ImageJsonModel Image { get; set; }
    }
}