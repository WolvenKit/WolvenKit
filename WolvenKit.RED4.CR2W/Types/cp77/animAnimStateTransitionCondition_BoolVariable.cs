using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_BoolVariable : animIAnimStateTransitionCondition
	{
		private CName _variableName;
		private CBool _compareValue;

		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get
			{
				if (_variableName == null)
				{
					_variableName = (CName) CR2WTypeManager.Create("CName", "variableName", cr2w, this);
				}
				return _variableName;
			}
			set
			{
				if (_variableName == value)
				{
					return;
				}
				_variableName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compareValue")] 
		public CBool CompareValue
		{
			get
			{
				if (_compareValue == null)
				{
					_compareValue = (CBool) CR2WTypeManager.Create("Bool", "compareValue", cr2w, this);
				}
				return _compareValue;
			}
			set
			{
				if (_compareValue == value)
				{
					return;
				}
				_compareValue = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_BoolVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
