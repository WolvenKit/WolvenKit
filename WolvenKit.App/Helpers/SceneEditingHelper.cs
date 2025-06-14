using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers
{
    /// <summary>
    /// Helper class for scene editing operations
    /// </summary>
    public static class SceneEditingHelper
    {
        /// <summary>
        /// Creates a new actor with automatic ID calculation and adds it to the scene
        /// </summary>
        /// <param name="sceneResource">The scene to add the actor to</param>
        /// <param name="actorName">Optional name for the actor</param>
        /// <param name="entityRef">Optional entity reference</param>
        /// <returns>The newly created actor</returns>
        public static scnActorDef CreateAndAddActor(scnSceneResource sceneResource, string? actorName = null, gameEntityReference? entityRef = null)
        {
            var actor = new scnActorDef();
            
            if (!string.IsNullOrEmpty(actorName))
            {
                actor.ActorName = actorName;
            }
            
            if (entityRef != null)
            {
                actor.FindActorInWorldParams.ActorRef = entityRef;
            }
            
            sceneResource.AddActor(actor);
            return actor;
        }
        
        /// <summary>
        /// Creates a new player actor with automatic ID calculation and adds it to the scene
        /// </summary>
        /// <param name="sceneResource">The scene to add the player actor to</param>
        /// <param name="playerName">Optional name for the player</param>
        /// <returns>The newly created player actor</returns>
        public static scnPlayerActorDef CreateAndAddPlayerActor(scnSceneResource sceneResource, string? playerName = null)
        {
            var playerActor = new scnPlayerActorDef();
            
            if (!string.IsNullOrEmpty(playerName))
            {
                playerActor.PlayerName = playerName;
            }
            
            sceneResource.AddPlayerActor(playerActor);
            return playerActor;
        }
        
        /// <summary>
        /// Fixes all actor IDs and performer debug symbols in a scene
        /// This is useful for scenes that were created before automatic ID calculation
        /// </summary>
        /// <param name="sceneResource">The scene to fix</param>
        public static void FixActorIdsAndPerformerSymbols(scnSceneResource sceneResource)
        {
            if (sceneResource == null) return;
            
            // Clear existing performer symbols
            sceneResource.DebugSymbols ??= new scnDebugSymbols();
            sceneResource.DebugSymbols.PerformersDebugSymbols.Clear();
            
            uint currentId = 0;
            
            // Fix regular actors
            foreach (var actor in sceneResource.Actors)
            {
                actor.ActorId.Id = currentId;
                
                // Create performer symbol
                var performerSymbol = new scnPerformerSymbol
                {
                    PerformerId = new scnPerformerId { Id = scnSceneResource.CalculatePerformerId(currentId) },
                    EntityRef = actor.FindActorInWorldParams?.ActorRef ?? new gameEntityReference { Names = new CArray<CName>() },
                    EditorPerformerId = new CRUID()
                };
                
                sceneResource.DebugSymbols.PerformersDebugSymbols.Add(performerSymbol);
                currentId++;
            }
            
            // Fix player actors
            foreach (var playerActor in sceneResource.PlayerActors)
            {
                playerActor.ActorId.Id = currentId;
                
                // Create performer symbol
                var performerSymbol = new scnPerformerSymbol
                {
                    PerformerId = new scnPerformerId { Id = scnSceneResource.CalculatePerformerId(currentId) },
                    EntityRef = new gameEntityReference { Names = new CArray<CName>() },
                    EditorPerformerId = new CRUID()
                };
                
                sceneResource.DebugSymbols.PerformersDebugSymbols.Add(performerSymbol);
                currentId++;
            }
        }
        
        /// <summary>
        /// Gets the performer ID for a given actor ID
        /// </summary>
        /// <param name="actorId">The actor ID</param>
        /// <returns>The corresponding performer ID</returns>
        public static uint GetPerformerIdForActor(uint actorId)
        {
            return scnSceneResource.CalculatePerformerId(actorId);
        }
        
        /// <summary>
        /// Gets the actor ID from a performer ID
        /// </summary>
        /// <param name="performerId">The performer ID</param>
        /// <returns>The corresponding actor ID, or null if not a valid actor performer ID</returns>
        public static uint? GetActorIdFromPerformerId(uint performerId)
        {
            // Check if this follows the actor performer pattern: 1 + index * 256
            if ((performerId - 1) % 256 == 0)
            {
                return (performerId - 1) / 256;
            }
            return null;
        }
    }
} 