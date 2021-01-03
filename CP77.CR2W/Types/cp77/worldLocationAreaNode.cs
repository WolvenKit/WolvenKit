using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNode : worldTriggerAreaNode
	{
		[Ordinal(0)]  [RED("locationName")] public CString LocationName { get; set; }

		public worldLocationAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
