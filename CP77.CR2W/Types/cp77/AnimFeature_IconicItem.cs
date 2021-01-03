using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IconicItem : animAnimFeature
	{
		[Ordinal(0)]  [RED("isActiveDrilling")] public CBool IsActiveDrilling { get; set; }
		[Ordinal(1)]  [RED("isFreeDrilling")] public CBool IsFreeDrilling { get; set; }
		[Ordinal(2)]  [RED("isItemEquipped")] public CBool IsItemEquipped { get; set; }
		[Ordinal(3)]  [RED("isScanToInteraction")] public CBool IsScanToInteraction { get; set; }
		[Ordinal(4)]  [RED("isScanning")] public CBool IsScanning { get; set; }

		public AnimFeature_IconicItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
