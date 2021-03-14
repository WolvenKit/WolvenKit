using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerQuickHackData : CVariable
	{
		private TweakDBID _alternativeName;
		private CName _factName;
		private CInt32 _factValue;
		private CEnum<EMathOperationType> _operationType;

		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get
			{
				if (_alternativeName == null)
				{
					_alternativeName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeName", cr2w, this);
				}
				return _alternativeName;
			}
			set
			{
				if (_alternativeName == value)
				{
					return;
				}
				_alternativeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CName) CR2WTypeManager.Create("CName", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get
			{
				if (_factValue == null)
				{
					_factValue = (CInt32) CR2WTypeManager.Create("Int32", "factValue", cr2w, this);
				}
				return _factValue;
			}
			set
			{
				if (_factValue == value)
				{
					return;
				}
				_factValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EMathOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EMathOperationType>) CR2WTypeManager.Create("EMathOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		public ComputerQuickHackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
