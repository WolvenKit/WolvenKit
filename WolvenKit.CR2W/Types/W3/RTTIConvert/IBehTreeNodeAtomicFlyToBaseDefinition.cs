using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeNodeAtomicFlyToBaseDefinition : IBehTreeNodeAtomicFlightDefinition
	{
		[RED("skipHeightCheck")] 		public CBool SkipHeightCheck { get; set;}

		[RED("useAbsoluteHeightDifference")] 		public CBool UseAbsoluteHeightDifference { get; set;}

		[RED("checkDistanceWithoutOffsets")] 		public CBool CheckDistanceWithoutOffsets { get; set;}

		[RED("distanceOffset")] 		public CBehTreeValFloat DistanceOffset { get; set;}

		[RED("heightOffset")] 		public CBehTreeValFloat HeightOffset { get; set;}

		[RED("min2DDistance")] 		public CBehTreeValFloat Min2DDistance { get; set;}

		[RED("minHeight")] 		public CBehTreeValFloat MinHeight { get; set;}

		public IBehTreeNodeAtomicFlyToBaseDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IBehTreeNodeAtomicFlyToBaseDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}