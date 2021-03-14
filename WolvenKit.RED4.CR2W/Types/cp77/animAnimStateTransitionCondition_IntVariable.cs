using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntVariable : animIAnimStateTransitionCondition
	{
		private CName _variableName;
		private CInt32 _compareValue;
		private CEnum<animCompareFunc> _compareFunc;

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
		public CInt32 CompareValue
		{
			get
			{
				if (_compareValue == null)
				{
					_compareValue = (CInt32) CR2WTypeManager.Create("Int32", "compareValue", cr2w, this);
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

		[Ordinal(2)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get
			{
				if (_compareFunc == null)
				{
					_compareFunc = (CEnum<animCompareFunc>) CR2WTypeManager.Create("animCompareFunc", "compareFunc", cr2w, this);
				}
				return _compareFunc;
			}
			set
			{
				if (_compareFunc == value)
				{
					return;
				}
				_compareFunc = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
