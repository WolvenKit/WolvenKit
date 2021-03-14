using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompareBuilder : IScriptable
	{
		private CFloat _fLOAT_EQUAL_EPSILON;
		private CInt32 _value;

		[Ordinal(0)] 
		[RED("FLOAT_EQUAL_EPSILON")] 
		public CFloat FLOAT_EQUAL_EPSILON
		{
			get
			{
				if (_fLOAT_EQUAL_EPSILON == null)
				{
					_fLOAT_EQUAL_EPSILON = (CFloat) CR2WTypeManager.Create("Float", "FLOAT_EQUAL_EPSILON", cr2w, this);
				}
				return _fLOAT_EQUAL_EPSILON;
			}
			set
			{
				if (_fLOAT_EQUAL_EPSILON == value)
				{
					return;
				}
				_fLOAT_EQUAL_EPSILON = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public CompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
