using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopSelectionChangeInfo : CVariable
	{
		[Ordinal(0)]  [RED("deselected")] public CArray<CUInt64> Deselected { get; set; }
		[Ordinal(1)]  [RED("selected")] public CArray<CUInt64> Selected { get; set; }

		public interopSelectionChangeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
