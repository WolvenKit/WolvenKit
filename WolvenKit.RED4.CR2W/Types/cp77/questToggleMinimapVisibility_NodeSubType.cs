using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleMinimapVisibility_NodeSubType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)] [RED("show")] public CBool Show { get; set; }

		public questToggleMinimapVisibility_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
