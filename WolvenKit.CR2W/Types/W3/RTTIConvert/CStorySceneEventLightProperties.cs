using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventLightProperties : CStorySceneEvent
	{
		[RED("lightId")] 		public CName LightId { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("additiveChanges")] 		public CBool AdditiveChanges { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		[RED("lightColorSource")] 		public CEnum<ESceneEventLightColorSource> LightColorSource { get; set;}

		[RED("radius")] 		public SSimpleCurve Radius { get; set;}

		[RED("brightness")] 		public SSimpleCurve Brightness { get; set;}

		[RED("attenuation")] 		public SSimpleCurve Attenuation { get; set;}

		[RED("placement")] 		public EngineTransform Placement { get; set;}

		[RED("flickering")] 		public SLightFlickering Flickering { get; set;}

		[RED("useGlobalCoords")] 		public CBool UseGlobalCoords { get; set;}

		[RED("spotLightProperties")] 		public SStorySceneSpotLightProperties SpotLightProperties { get; set;}

		[RED("dimmerProperties")] 		public SStorySceneLightDimmerProperties DimmerProperties { get; set;}

		[RED("attachment")] 		public SStorySceneAttachmentInfo Attachment { get; set;}

		[RED("lightTracker")] 		public SStorySceneLightTrackingInfo LightTracker { get; set;}

		public CStorySceneEventLightProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventLightProperties(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}