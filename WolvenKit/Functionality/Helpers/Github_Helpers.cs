using Octokit;

namespace WolvenKit.Functionality.Helpers
{
    public static class Github_Helpers
    {
        // Authenticate with github.
        public static Credentials GhubAuth(string u, string p) => new(u, p);
    }
}
