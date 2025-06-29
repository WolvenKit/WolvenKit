namespace WolvenKit.RED4.Types;

public partial class scnSceneResource
{
    /// <summary>
    /// Adds an actor to the scene with automatic ID calculation and performer debug symbol creation
    /// </summary>
    /// <param name="actor">The actor to add</param>
    public void AddActor(scnActorDef actor)
    {
        if (actor == null) return;
        
        // Initialize the actor with automatic ID and performer symbol
        actor.InitializeInScene(this);
        
        // Add to actors collection
        Actors.Add(actor);
    }
    
    /// <summary>
    /// Adds a player actor to the scene with automatic ID calculation and performer debug symbol creation
    /// </summary>
    /// <param name="playerActor">The player actor to add</param>
    public void AddPlayerActor(scnPlayerActorDef playerActor)
    {
        if (playerActor == null) return;
        
        // Initialize the player actor with automatic ID and performer symbol
        playerActor.InitializeInScene(this);
        
        // Add to player actors collection
        PlayerActors.Add(playerActor);
    }
    
    /// <summary>
    /// Gets the next available actor ID
    /// </summary>
    /// <returns>The next actor ID that should be used</returns>
    public uint GetNextActorId()
    {
        return (uint)(Actors.Count + PlayerActors.Count);
    }
    
    /// <summary>
    /// Calculates the performer ID for a given actor index
    /// </summary>
    /// <param name="actorIndex">The actor index (0, 1, 2, etc.)</param>
    /// <returns>The corresponding performer ID (1, 257, 513, etc.)</returns>
    public static uint CalculatePerformerId(uint actorIndex)
    {
        return 1 + actorIndex * 256;
    }
} 