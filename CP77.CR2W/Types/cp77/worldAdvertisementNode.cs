using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAdvertisementNode : worldStaticMeshNode
	{
		[Ordinal(13)] [RED("meshInitialScale")] public Vector3 MeshInitialScale { get; set; }
		[Ordinal(14)] [RED("format")] public CEnum<AdvertisementFormat> Format { get; set; }
		[Ordinal(15)] [RED("adGroupTDBID")] public TweakDBID AdGroupTDBID { get; set; }
		[Ordinal(16)] [RED("enableOverride")] public CBool EnableOverride { get; set; }
		[Ordinal(17)] [RED("adOverrideTDBID")] public TweakDBID AdOverrideTDBID { get; set; }
		[Ordinal(18)] [RED("adVersion")] public CUInt32 AdVersion { get; set; }
		[Ordinal(19)] [RED("glitchValue")] public CFloat GlitchValue { get; set; }
		[Ordinal(20)] [RED("lightsData")] public CArray<worldAdvertisementLightData> LightsData { get; set; }

		public worldAdvertisementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
