using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneLightTrackingInfo : CVariable
	{
		[Ordinal(1)] [RED("enable")] 		public CBool Enable { get; set;}

		[Ordinal(2)] [RED("trackingType")] 		public CEnum<ELightTrackingType> TrackingType { get; set;}

		[Ordinal(3)] [RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[Ordinal(4)] [RED("angleOffset")] 		public SSimpleCurve AngleOffset { get; set;}

		public SStorySceneLightTrackingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneLightTrackingInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}