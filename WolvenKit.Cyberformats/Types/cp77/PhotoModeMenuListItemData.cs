using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItemData : ListItemData
	{
		[Ordinal(1)] [RED("attributeKey")] public CUInt32 AttributeKey { get; set; }

		public PhotoModeMenuListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
