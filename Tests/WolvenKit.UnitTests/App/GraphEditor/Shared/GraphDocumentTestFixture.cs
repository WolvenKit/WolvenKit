using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.Modkit.RED4.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.UnitTests.App.GraphEditor.Shared;

internal sealed class GraphDocumentTestFixture : IDisposable
{
    private const string EmptyState = """
        {"EditorX":0,"EditorY":0,"EditorZ":0,"Nodes":[]}
        """;

    public GraphDocumentTestFixture(string relativePath = "mod\\test.scene")
    {
        ProjectDirectory = Path.Combine(Path.GetTempPath(), "WolvenKit.GraphTests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(ProjectDirectory);

        var project = new Cp77Project(
            Path.Combine(ProjectDirectory, "GraphTests.cpmodproj"),
            "GraphTests",
            "GraphTests");
        var projectManager = new Mock<IProjectManager>();
        projectManager.SetupGet(manager => manager.ActiveProject).Returns(project);

        // The production constructor builds the complete tab UI; graph lifecycle tests only need this state.
        Document = (RedDocumentViewModel)RuntimeHelpers.GetUninitializedObject(typeof(RedDocumentViewModel));
        SetPrivateField(Document, "_projectManager", projectManager.Object);
        SetPrivateField(Document, "_path", relativePath);
        Document.ContentId = relativePath;
        Document.FilePath = relativePath;
        Document.TabItemViewModels = new ObservableCollection<RedDocumentTabViewModel>();
        Document.SetIsDirty(false);
    }

    public RedDocumentViewModel Document { get; }

    public string ProjectDirectory { get; }

    public string GetStatePath(string stateParents = "", string extension = ".json") =>
        Path.Combine(ProjectDirectory, "GraphEditorStates", Document.RelativePath + stateParents + extension);

    public void EnableStateLoading(string stateParents = "")
    {
        var statePath = GetStatePath(stateParents);
        Directory.CreateDirectory(Path.GetDirectoryName(statePath)!);
        File.WriteAllText(statePath, EmptyState);
    }

    public void Dispose()
    {
        if (Directory.Exists(ProjectDirectory))
        {
            Directory.Delete(ProjectDirectory, true);
        }
    }

    private static void SetPrivateField<T>(T target, string fieldName, object value)
    {
        var field = typeof(T).GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic) ??
                    throw new InvalidOperationException($"Could not find field {fieldName} on {typeof(T).Name}.");
        field.SetValue(target, value);
    }
}
