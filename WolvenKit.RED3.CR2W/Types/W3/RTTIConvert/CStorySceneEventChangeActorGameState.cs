using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventChangeActorGameState : CStorySceneEvent
	{
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("snapToTerrain")] 		public CBool SnapToTerrain { get; set;}

		[Ordinal(3)] [RED("snapToTerrainDuration")] 		public CFloat SnapToTerrainDuration { get; set;}

		[Ordinal(4)] [RED("blendPoseDuration")] 		public CFloat BlendPoseDuration { get; set;}

		[Ordinal(5)] [RED("forceResetClothAndDangles")] 		public CBool ForceResetClothAndDangles { get; set;}

		[Ordinal(6)] [RED("switchToGameplayPose")] 		public CBool SwitchToGameplayPose { get; set;}

		[Ordinal(7)] [RED("gameplayPoseTypeName")] 		public CName GameplayPoseTypeName { get; set;}

		[Ordinal(8)] [RED("raiseGlobalBehaviorEvent")] 		public CName RaiseGlobalBehaviorEvent { get; set;}

		[Ordinal(9)] [RED("activateBehaviorGraph")] 		public CInt32 ActivateBehaviorGraph { get; set;}

		[Ordinal(10)] [RED("startGameplayAction")] 		public CInt32 StartGameplayAction { get; set;}

		public CStorySceneEventChangeActorGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventChangeActorGameState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}