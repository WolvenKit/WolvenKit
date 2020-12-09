using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventScenePropPlacement : CStorySceneEvent
	{
		[Ordinal(1)] [RED("propId")] 		public CName PropId { get; set;}

		[Ordinal(2)] [RED("placement")] 		public EngineTransform Placement { get; set;}

		[Ordinal(3)] [RED("showHide")] 		public CBool ShowHide { get; set;}

		[Ordinal(4)] [RED("rotationCyclesPitch")] 		public CUInt32 RotationCyclesPitch { get; set;}

		[Ordinal(5)] [RED("rotationCyclesRoll")] 		public CUInt32 RotationCyclesRoll { get; set;}

		[Ordinal(6)] [RED("rotationCyclesYaw")] 		public CUInt32 RotationCyclesYaw { get; set;}

		public CStorySceneEventScenePropPlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventScenePropPlacement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}