using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupEntry : CVariable
	{
		[Ordinal(0)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(1)] [RED("animSet")] public raRef<animAnimSet> AnimSet { get; set; }
		[Ordinal(2)] [RED("variableNames")] public CArray<CName> VariableNames { get; set; }

		public animAnimSetupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
