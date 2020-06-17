using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemDynamicLight : CFXTrackItemCurveBase
	{
		[RED("color")] 		public CColor Color { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("brightness")] 		public CFloat Brightness { get; set;}

		[RED("attenuation")] 		public CFloat Attenuation { get; set;}

		[RED("specularScale")] 		public CFloat SpecularScale { get; set;}

		[RED("lightChannels")] 		public ELightChannel LightChannels { get; set;}

		[RED("isCastingShadows")] 		public CBool IsCastingShadows { get; set;}

		[RED("isModulative")] 		public CBool IsModulative { get; set;}

		[RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[RED("colorGroup")] 		public EEnvColorGroup ColorGroup { get; set;}

		[RED("isSpotlight")] 		public CBool IsSpotlight { get; set;}

		[RED("spotInnerAngle")] 		public CFloat SpotInnerAngle { get; set;}

		[RED("spotOuterAngle")] 		public CFloat SpotOuterAngle { get; set;}

		[RED("spawner")] 		public CPtr<IFXSpawner> Spawner { get; set;}

		public CFXTrackItemDynamicLight(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFXTrackItemDynamicLight(cr2w);

	}
}