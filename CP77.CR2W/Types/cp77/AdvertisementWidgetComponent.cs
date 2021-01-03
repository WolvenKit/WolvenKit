using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(0)]  [RED("adGroupTDBID")] public TweakDBID AdGroupTDBID { get; set; }
		[Ordinal(1)]  [RED("adOverrideTDBID")] public TweakDBID AdOverrideTDBID { get; set; }
		[Ordinal(2)]  [RED("adVersion")] public CUInt32 AdVersion { get; set; }
		[Ordinal(3)]  [RED("enableOverride")] public CBool EnableOverride { get; set; }
		[Ordinal(4)]  [RED("format")] public CEnum<AdvertisementFormat> Format { get; set; }
		[Ordinal(5)]  [RED("useOnlyAttachedLights")] public CBool UseOnlyAttachedLights { get; set; }

		public AdvertisementWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
