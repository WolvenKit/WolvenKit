namespace WolvenKit.RED4.Types;

public partial class scnActorDef
{
    /// <summary>
    /// Sets up the actor with automatic ID calculation and creates corresponding performer debug symbol
    /// </summary>
    /// <param name="sceneResource">The scene resource to add this actor to</param>
    public void InitializeInScene(scnSceneResource sceneResource)
    {
        if (sceneResource == null) return;
        
        // Calculate the next actor ID (0, 1, 2, etc.)
        uint nextActorId = (uint)sceneResource.Actors.Count;
        ActorId.Id = nextActorId;
        
        // Create performer debug symbol with calculated performer ID
        // Formula: performerId = 1 + actorIndex * 256
        uint performerId = 1 + nextActorId * 256;
        
        var performerSymbol = new scnPerformerSymbol
        {
            PerformerId = new scnPerformerId { Id = performerId },
            EntityRef = new gameEntityReference
            {
                Names = FindActorInWorldParams?.ActorRef?.Names ?? new CArray<CName>()
            },
            EditorPerformerId = new CRUID()
        };
        
        // Transfer entityRef from actor to performer symbol
        if (FindActorInWorldParams?.ActorRef != null)
        {
            performerSymbol.EntityRef = FindActorInWorldParams.ActorRef;
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