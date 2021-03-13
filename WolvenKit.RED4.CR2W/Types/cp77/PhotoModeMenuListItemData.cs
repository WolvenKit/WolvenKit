using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItemData : ListItemData
	{
		[Ordinal(1)] [RED("attributeKey")] public CUInt32 AttributeKey { get; set; }

		public PhotoModeMenuListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
