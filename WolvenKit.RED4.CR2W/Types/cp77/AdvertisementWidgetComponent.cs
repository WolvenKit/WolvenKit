using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(10)] [RED("format")] public CEnum<AdvertisementFormat> Format { get; set; }
		[Ordinal(11)] [RED("adGroupTDBID")] public TweakDBID AdGroupTDBID { get; set; }
		[Ordinal(12)] [RED("enableOverride")] public CBool EnableOverride { get; set; }
		[Ordinal(13)] [RED("adOverrideTDBID")] public TweakDBID AdOverrideTDBID { get; set; }
		[Ordinal(14)] [RED("adVersion")] public CUInt32 AdVersion { get; set; }
		[Ordinal(15)] [RED("useOnlyAttachedLights")] public CBool UseOnlyAttachedLights { get; set; }

		public AdvertisementWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
