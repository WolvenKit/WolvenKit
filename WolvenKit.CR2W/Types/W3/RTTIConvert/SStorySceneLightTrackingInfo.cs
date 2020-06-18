using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneLightTrackingInfo : CVariable
	{
		[RED("enable")] 		public CBool Enable { get; set;}

		[RED("trackingType")] 		public CEnum<ELightTrackingType> TrackingType { get; set;}

		[RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[RED("angleOffset")] 		public SSimpleCurve AngleOffset { get; set;}

		public SStorySceneLightTrackingInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStorySceneLightTrackingInfo(cr2w);

	}
}