using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(0)]  [RED("format")] public CEnum<AdvertisementFormat> Format { get; set; }
		[Ordinal(1)]  [RED("adGroupTDBID")] public TweakDBID AdGroupTDBID { get; set; }
		[Ordinal(2)]  [RED("enableOverride")] public CBool EnableOverride { get; set; }
		[Ordinal(3)]  [RED("adOverrideTDBID")] public TweakDBID AdOverrideTDBID { get; set; }
		[Ordinal(4)]  [RED("adVersion")] public CUInt32 AdVersion { get; set; }
		[Ordinal(5)]  [RED("useOnlyAttachedLights")] public CBool UseOnlyAttachedLights { get; set; }

		public AdvertisementWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
