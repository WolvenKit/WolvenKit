using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompareArgumentsInts : CompareArguments
	{
		private CEnum<ECompareOp> _comparator;

		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetProperty(ref _comparator);
			set => SetProperty(ref _comparator, value);
		}

		public CompareArgumentsInts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
