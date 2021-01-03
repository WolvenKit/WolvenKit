using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questToggleStealthMappinVisibility_NodeSubType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)]  [RED("show")] public CBool Show { get; set; }

		public questToggleStealthMappinVisibility_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
