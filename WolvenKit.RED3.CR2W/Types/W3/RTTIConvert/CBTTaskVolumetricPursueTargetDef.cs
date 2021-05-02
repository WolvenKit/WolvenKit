using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricPursueTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("distanceOffset")] 		public CFloat DistanceOffset { get; set;}

		[Ordinal(2)] [RED("heightOffset")] 		public CFloat HeightOffset { get; set;}

		[Ordinal(3)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(4)] [RED("minHeight")] 		public CFloat MinHeight { get; set;}

		[Ordinal(5)] [RED("completeWithSucces")] 		public CBool CompleteWithSucces { get; set;}

		[Ordinal(6)] [RED("useAbsoluteHeightDifference")] 		public CBool UseAbsoluteHeightDifference { get; set;}

		[Ordinal(7)] [RED("checkDistanceWithoutOffsets")] 		public CBool CheckDistanceWithoutOffsets { get; set;}

		[Ordinal(8)] [RED("skipHeightCheck")] 		public CBool SkipHeightCheck { get; set;}

		[Ordinal(9)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskVolumetricPursueTargetDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricPursueTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}