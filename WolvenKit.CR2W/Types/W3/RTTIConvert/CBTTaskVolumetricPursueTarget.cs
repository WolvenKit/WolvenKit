using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricPursueTarget : CBTTaskVolumetricMove
	{
		[RED("distanceOffset")] 		public CFloat DistanceOffset { get; set;}

		[RED("heightOffset")] 		public CFloat HeightOffset { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("minHeight")] 		public CFloat MinHeight { get; set;}

		[RED("completeWithSucces")] 		public CBool CompleteWithSucces { get; set;}

		[RED("useAbsoluteHeightDifference")] 		public CBool UseAbsoluteHeightDifference { get; set;}

		[RED("checkDistanceWithoutOffsets")] 		public CBool CheckDistanceWithoutOffsets { get; set;}

		[RED("skipHeightCheck")] 		public CBool SkipHeightCheck { get; set;}

		[RED("distanceDiff")] 		public CFloat DistanceDiff { get; set;}

		[RED("heightDiff")] 		public CFloat HeightDiff { get; set;}

		[RED("isMinHeightNegative")] 		public CBool IsMinHeightNegative { get; set;}

		public CBTTaskVolumetricPursueTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricPursueTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}