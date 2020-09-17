using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneLight : IStorySceneItem
	{
		[Ordinal(1)] [RED("id")] 		public CName Id { get; set;}

		[Ordinal(2)] [RED("type")] 		public CEnum<ELightType> Type { get; set;}

		[Ordinal(3)] [RED("innerAngle")] 		public CFloat InnerAngle { get; set;}

		[Ordinal(4)] [RED("outerAngle")] 		public CFloat OuterAngle { get; set;}

		[Ordinal(5)] [RED("softness")] 		public CFloat Softness { get; set;}

		[Ordinal(6)] [RED("shadowCastingMode")] 		public CEnum<ELightShadowCastingMode> ShadowCastingMode { get; set;}

		[Ordinal(7)] [RED("shadowFadeDistance")] 		public CFloat ShadowFadeDistance { get; set;}

		[Ordinal(8)] [RED("shadowFadeRange")] 		public CFloat ShadowFadeRange { get; set;}

		[Ordinal(9)] [RED("dimmerType")] 		public CEnum<EDimmerType> DimmerType { get; set;}

		[Ordinal(10)] [RED("dimmerAreaMarker")] 		public CBool DimmerAreaMarker { get; set;}

		public CStorySceneLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneLight(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}