using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemDynamicLight : CFXTrackItemCurveBase
	{
		[Ordinal(1)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(2)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(3)] [RED("brightness")] 		public CFloat Brightness { get; set;}

		[Ordinal(4)] [RED("attenuation")] 		public CFloat Attenuation { get; set;}

		[Ordinal(5)] [RED("specularScale")] 		public CFloat SpecularScale { get; set;}

		[Ordinal(6)] [RED("lightChannels")] 		public CEnum<ELightChannel> LightChannels { get; set;}

		[Ordinal(7)] [RED("isCastingShadows")] 		public CBool IsCastingShadows { get; set;}

		[Ordinal(8)] [RED("isModulative")] 		public CBool IsModulative { get; set;}

		[Ordinal(9)] [RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		[Ordinal(10)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(11)] [RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[Ordinal(12)] [RED("colorGroup")] 		public CEnum<EEnvColorGroup> ColorGroup { get; set;}

		[Ordinal(13)] [RED("isSpotlight")] 		public CBool IsSpotlight { get; set;}

		[Ordinal(14)] [RED("spotInnerAngle")] 		public CFloat SpotInnerAngle { get; set;}

		[Ordinal(15)] [RED("spotOuterAngle")] 		public CFloat SpotOuterAngle { get; set;}

		[Ordinal(16)] [RED("spawner")] 		public CPtr<IFXSpawner> Spawner { get; set;}

		public CFXTrackItemDynamicLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemDynamicLight(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}