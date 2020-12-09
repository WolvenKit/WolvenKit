using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLightProperties : CStorySceneEvent
	{
		[Ordinal(1)] [RED("lightId")] 		public CName LightId { get; set;}

		[Ordinal(2)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(3)] [RED("additiveChanges")] 		public CBool AdditiveChanges { get; set;}

		[Ordinal(4)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(5)] [RED("lightColorSource")] 		public CEnum<ESceneEventLightColorSource> LightColorSource { get; set;}

		[Ordinal(6)] [RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[Ordinal(7)] [RED("brightness")] 		public SSimpleCurve Brightness { get; set;}

		[Ordinal(8)] [RED("attenuation")] 		public SSimpleCurve Attenuation { get; set;}

		[Ordinal(9)] [RED("placement")] 		public EngineTransform Placement { get; set;}

		[Ordinal(10)] [RED("flickering")] 		public SLightFlickering Flickering { get; set;}

		[Ordinal(11)] [RED("useGlobalCoords")] 		public CBool UseGlobalCoords { get; set;}

		[Ordinal(12)] [RED("spotLightProperties")] 		public SStorySceneSpotLightProperties SpotLightProperties { get; set;}

		[Ordinal(13)] [RED("dimmerProperties")] 		public SStorySceneLightDimmerProperties DimmerProperties { get; set;}

		[Ordinal(14)] [RED("attachment")] 		public SStorySceneAttachmentInfo Attachment { get; set;}

		[Ordinal(15)] [RED("lightTracker")] 		public SStorySceneLightTrackingInfo LightTracker { get; set;}

		public CStorySceneEventLightProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventLightProperties(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}