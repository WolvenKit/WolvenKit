using System.Collections.Generic;
using System.Linq;
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

        public static string? GetActorNameById(uint actorId, scnSceneResource sceneResource) =>
            sceneResource.Actors.FirstOrDefault(a => a.ActorId.Id == actorId)?.ActorName
            ?? sceneResource.PlayerActors.FirstOrDefault(a => a.ActorId.Id == actorId)?.PlayerName;

        public static string? GetActorNameByPerformerId(uint performerId, scnSceneResource sceneResource)
        {
            var actorId = GetActorIdFromPerformerId(performerId) ?? int.MaxValue;
            return GetActorNameById(actorId, sceneResource);
        }

        public static string? GetPerformerNameById(uint performerId, scnSceneResource sceneResource) =>
            GetActorNameByPerformerId(performerId, sceneResource)
            ?? GetPropNameByPerformerId(performerId, sceneResource);


        #region voicelines

        /// <summary>
        /// Called with actual screenplay line ID
        /// </summary>

        public static string? GetScreenplayLineById(CUInt32 screenplayId, scnSceneResource scene)
        {
            var screenplayLine = scene.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);

            if (screenplayLine?.LocstringId == null ||
                scene.LocStore?.VdEntries == null ||
                scene.LocStore?.VpEntries == null)
            {
                return "";
            }

            return GetLocstringValueById(screenplayLine.LocstringId.Ruid, scene);
        }



        /// <summary>
        /// This is called from ChunkViewModel.Value, we need to find the correct screenplayLine first
        /// </summary>
        public static string? GetScreenplayLineByLocstringId(CUInt64 locstringId, scnSceneResource scene)
        {
            var option = scene.ScreenplayStore.Options.FirstOrDefault(o => o.LocstringId.Ruid == locstringId);
            if (option is null)
            {
                return null;
            }
            return GetScreenplayLineById(option.ItemId.Id, scene);

        }

        public static string? GetLocstringValueById(CRUID locstringRuid, scnSceneResource scene)
        {
            var preferredLocaleId = WolvenKit.RED4.Types.Enums.scnlocLocaleId.en_us;
            var vdEntry = scene.LocStore.VdEntries.FirstOrDefault(vd =>
                vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId == preferredLocaleId);

            if (vdEntry?.VariantId == null)
            {
                return "";
            }

            return GetLocstringValueByVariantId(vdEntry.VariantId.Ruid, scene);

        }

        public static string? GetLocstringValueByVariantId(CRUID variantId, scnSceneResource scene)
        {
            var vpEntry = scene.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId.Ruid == variantId);

            return StringHelper.Truncate(vpEntry?.Content.ToString() ?? "", 40);
        }

#endregion

        public static string? GetPropNameByPerformerId(uint propPerformerId, scnSceneResource scene)
        {
            if (propPerformerId < 2 || (propPerformerId - 2) % 256 != 0)
            {
                return null;
            }

            return GetPropNameById(scnSceneResource.CalculatePropIdFromPerformerId(propPerformerId), scene);
        }

        public static string? GetPropNameById(uint propId, scnSceneResource scene)
        {
            if (scene.Props.FirstOrDefault(p => p.PropId?.Id == propId)?.PropName is CString s && !string.IsNullOrEmpty(s))
            {
                return s;
            }
            return null;
        }

#region screenplay item ids

        /// <summary>
        /// The step between screenplay item ids, as the game's own scenes number them. An id lower
        /// than the one before it makes the previous entry's text play; a gap larger than a step
        /// makes nothing play at all.
        /// </summary>
        public const uint ScreenplayItemIdStep = 256;

        /// <summary>What dialogue lines number from when the screenplay store holds none.</summary>
        public const uint FirstDialogLineItemId = 1;

        /// <summary>What choice options number from when the screenplay store holds none.</summary>
        public const uint FirstChoiceOptionItemId = 2;

        /// <summary>
        /// The id <c>new scnscreenplayItemId()</c> starts on, which is what an entry added through
        /// the raw array editor carries until someone gives it one. Never a real id, and too near
        /// the top of a uint to count a step up from.
        /// </summary>
        public const uint UnassignedScreenplayItemId = 4294967040;

        /// <summary>
        /// The next free item id for one half of a screenplay store.
        /// </summary>
        /// <remarks>
        /// The highest id in use is counted up from, not the last entry's: nothing keeps the array
        /// in order, so a store whose entries were added or reordered through the raw chunk editor
        /// can carry its highest id anywhere. Handing out an id that is already taken is not a
        /// cosmetic problem - graph events bind to their screenplay entry by item id, so a
        /// collision makes a <c>scnDialogLineEvent</c> play the wrong line.
        /// </remarks>
        /// <param name="itemIds">The ids already in that half of the store, in any order.</param>
        /// <param name="firstItemId">What the half numbers from when it is empty.</param>
        public static uint GetNextScreenplayItemId(IEnumerable<uint> itemIds, uint firstItemId)
        {
            var next = firstItemId;

            foreach (var itemId in itemIds)
            {
                // Ids too near the top of a uint to step past - the unassigned one above among them
                // - are left out of the reckoning. Counting up from one wraps to 0, which is an id
                // every unassigned entry would then answer to.
                if (itemId > uint.MaxValue - ScreenplayItemIdStep)
                {
                    continue;
                }

                if (itemId >= next)
                {
                    next = itemId + ScreenplayItemIdStep;
                }
            }

            return next;
        }

        /// <inheritdoc cref="GetNextScreenplayItemId(IEnumerable{uint}, uint)"/>
        public static uint GetNextDialogLineItemId(IEnumerable<scnscreenplayDialogLine>? lines) =>
            GetNextScreenplayItemId(
                lines?.Select(line => ItemIdOf(line?.ItemId)) ?? [],
                FirstDialogLineItemId);

        /// <inheritdoc cref="GetNextScreenplayItemId(IEnumerable{uint}, uint)"/>
        public static uint GetNextChoiceOptionItemId(IEnumerable<scnscreenplayChoiceOption>? options) =>
            GetNextScreenplayItemId(
                options?.Select(option => ItemIdOf(option?.ItemId)) ?? [],
                FirstChoiceOptionItemId);

        /// <summary>An entry's id, or the unassigned one where the raw editor left it without.</summary>
        private static uint ItemIdOf(scnscreenplayItemId? itemId) =>
            itemId is null ? UnassignedScreenplayItemId : itemId.Id;

#endregion
    }
}
