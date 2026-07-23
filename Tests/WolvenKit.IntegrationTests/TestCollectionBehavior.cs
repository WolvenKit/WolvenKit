using Xunit;

// Integration tests in this assembly spin up a real application host (IntegrationTestHost.Create), which
// mutates PROCESS-GLOBAL state: the Splat/ReactiveUI service locator (UseMicrosoftDependencyResolver +
// InitializeSplat), the shared AppData config.json (SettingsManager), and Application.Current. xunit
// parallelizes across test CLASSES by default, so two host-based classes running concurrently corrupt
// each other's locator and race on config.json (observed as "service locator is probably broken" and
// "config.json is being used by another process"). Serialize the whole assembly so only one host-based
// test runs at a time. The mock-based tests here are few and fast, so the lost parallelism is negligible.
[assembly: CollectionBehavior(DisableTestParallelization = true)]
