using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		private CName _variableToCompare;
		private CFloat _valueToCompare;

		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get
			{
				if (_variableToCompare == null)
				{
					_variableToCompare = (CName) CR2WTypeManager.Create("CName", "variableToCompare", cr2w, this);
				}
				return _variableToCompare;
			}
			set
			{
				if (_variableToCompare == value)
				{
					return;
				}
				_variableToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get
			{
				if (_valueToCompare == null)
				{
					_valueToCompare = (CFloat) CR2WTypeManager.Create("Float", "valueToCompare", cr2w, this);
				}
				return _valueToCompare;
			}
			set
			{
				if (_valueToCompare == value)
				{
					return;
				}
				_valueToCompare = value;
				PropertySet(this);
			}
		}

		public animAnimsetVariableCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
