using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentInt : CheckArguments
	{
		private CInt32 _customVar;
		private CEnum<ECompareOp> _comparator;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CInt32 CustomVar
		{
			get
			{
				if (_customVar == null)
				{
					_customVar = (CInt32) CR2WTypeManager.Create("Int32", "customVar", cr2w, this);
				}
				return _customVar;
			}
			set
			{
				if (_customVar == value)
				{
					return;
				}
				_customVar = value;
				PropertySet(this);
			}
		}

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

		public CheckArgumentInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
