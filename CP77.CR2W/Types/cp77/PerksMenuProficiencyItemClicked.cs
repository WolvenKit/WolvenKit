using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		[Ordinal(0)]  [RED("index")] public CInt32 Index { get; set; }

		public PerksMenuProficiencyItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
