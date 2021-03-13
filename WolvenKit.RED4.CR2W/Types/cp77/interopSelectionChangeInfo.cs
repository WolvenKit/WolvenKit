using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopSelectionChangeInfo : CVariable
	{
		[Ordinal(0)] [RED("selected")] public CArray<CUInt64> Selected { get; set; }
		[Ordinal(1)] [RED("deselected")] public CArray<CUInt64> Deselected { get; set; }

		public interopSelectionChangeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
