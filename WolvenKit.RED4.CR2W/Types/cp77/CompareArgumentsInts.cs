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
			get
			{
				if (_comparator == null)
				{
					_comparator = (CEnum<ECompareOp>) CR2WTypeManager.Create("ECompareOp", "comparator", cr2w, this);
				}
				return _comparator;
			}
			set
			{
				if (_comparator == value)
				{
					return;
				}
				_comparator = value;
				PropertySet(this);
			}
		}

		public CompareArgumentsInts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
