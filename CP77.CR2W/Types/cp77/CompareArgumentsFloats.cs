using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CompareArgumentsFloats : CompareArguments
	{
		[Ordinal(0)]  [RED("comparator")] public CEnum<ECompareOp> Comparator { get; set; }

		public CompareArgumentsFloats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
