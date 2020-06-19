using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneLight : IStorySceneItem
	{
		[RED("id")] 		public CName Id { get; set;}

		[RED("type")] 		public CEnum<ELightType> Type { get; set;}

		[RED("innerAngle")] 		public CFloat InnerAngle { get; set;}

		[RED("outerAngle")] 		public CFloat OuterAngle { get; set;}

		[RED("softness")] 		public CFloat Softness { get; set;}

		[RED("shadowCastingMode")] 		public CEnum<ELightShadowCastingMode> ShadowCastingMode { get; set;}

		[RED("shadowFadeDistance")] 		public CFloat ShadowFadeDistance { get; set;}

		[RED("shadowFadeRange")] 		public CFloat ShadowFadeRange { get; set;}

		[RED("dimmerType")] 		public CEnum<EDimmerType> DimmerType { get; set;}

		[RED("dimmerAreaMarker")] 		public CBool DimmerAreaMarker { get; set;}

		public CStorySceneLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneLight(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}