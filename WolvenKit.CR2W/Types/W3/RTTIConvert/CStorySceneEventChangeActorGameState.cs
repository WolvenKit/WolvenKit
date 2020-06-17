using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventChangeActorGameState : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("snapToTerrain")] 		public CBool SnapToTerrain { get; set;}

		[RED("snapToTerrainDuration")] 		public CFloat SnapToTerrainDuration { get; set;}

		[RED("blendPoseDuration")] 		public CFloat BlendPoseDuration { get; set;}

		[RED("forceResetClothAndDangles")] 		public CBool ForceResetClothAndDangles { get; set;}

		[RED("switchToGameplayPose")] 		public CBool SwitchToGameplayPose { get; set;}

		[RED("gameplayPoseTypeName")] 		public CName GameplayPoseTypeName { get; set;}

		[RED("raiseGlobalBehaviorEvent")] 		public CName RaiseGlobalBehaviorEvent { get; set;}

		[RED("activateBehaviorGraph")] 		public CInt32 ActivateBehaviorGraph { get; set;}

		[RED("startGameplayAction")] 		public CInt32 StartGameplayAction { get; set;}

		public CStorySceneEventChangeActorGameState(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventChangeActorGameState(cr2w);

	}
}