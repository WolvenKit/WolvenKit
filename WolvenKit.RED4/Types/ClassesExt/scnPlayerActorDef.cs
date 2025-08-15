namespace WolvenKit.RED4.Types;

public partial class scnPlayerActorDef
{
    /// <summary>
    /// Sets up the player actor with automatic ID calculation and creates corresponding performer debug symbol
    /// </summary>
    /// <param name="sceneResource">The scene resource to add this player actor to</param>
    public void InitializeInScene(scnSceneResource sceneResource)
    {
        if (sceneResource == null) return;
        
        // Calculate the next actor ID considering both regular actors and player actors
        uint nextActorId = (uint)(sceneResource.Actors.Count + sceneResource.PlayerActors.Count);
        ActorId.Id = nextActorId;
        
        // Create performer debug symbol with calculated performer ID
        // Formula: performerId = 1 + actorIndex * 256
        uint performerId = 1 + nextActorId * 256;
        
        var performerSymbol = new scnPerformerSymbol
        {
            PerformerId = new scnPerformerId { Id = performerId },
            EntityRef = new gameEntityReference
            {
                Names = new CArray<CName>()
            },
            EditorPerformerId = new CRUID()
        };
        
        // Set up default player entity reference if not already set
        if (string.IsNullOrEmpty(PlayerName))
        {
            PlayerName = "Player";
        }
        
        // Ensure debug symbols exist
        if (sceneResource.DebugSymbols == null)
        {
            sceneResource.DebugSymbols = new scnDebugSymbols();
        }
        
        // Add the performer symbol to debug symbols
        sceneResource.DebugSymbols.PerformersDebugSymbols.Add(performerSymbol);
    }
} 