using Newtonsoft.Json;

namespace WolvenKit.App.Models;

public class MinimalGithubRelease
{
    [JsonProperty("tag_name")] 
    public string TagName { get; set; } = "";
    
    [JsonProperty("assets")] 
    public MinimalGithubReleaseAsset[] Assets { get; set; } = [];
}

public class MinimalGithubReleaseAsset
{
    [JsonProperty("name")] 
    public string Name { get; set; } = "";
    
    [JsonProperty("browser_download_url")] 
    public string DownloadUrl { get; set; } = "";
    
    [JsonProperty("digest")] 
    public string? Digest { get; set; } = "";
    
    [JsonProperty("size")] 
    public long Size { get; set; } = 0;
}