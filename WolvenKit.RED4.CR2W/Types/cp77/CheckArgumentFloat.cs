using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentFloat : CheckArguments
	{
		[Ordinal(1)] [RED("customVar")] public CFloat CustomVar { get; set; }
		[Ordinal(2)] [RED("comparator")] public CEnum<ECompareOp> Comparator { get; set; }

		public CheckArgumentFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
