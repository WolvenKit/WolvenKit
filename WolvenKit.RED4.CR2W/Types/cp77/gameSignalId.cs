using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSignalId : CVariable
	{
		[Ordinal(0)] [RED("value")] public CUInt16 Value { get; set; }

		public gameSignalId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
