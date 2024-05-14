using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("name1")]
    public string name1 { get; set; }

    [JsonProperty("name2")]
    public string name2 { get; set; }

    [JsonProperty("lovePercentage")]
    public string lovePercentage { get; set; }

    [JsonProperty("response")]
    public string response { get; set; }

    [JsonProperty("additionalText")]
    public string additionalText { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
