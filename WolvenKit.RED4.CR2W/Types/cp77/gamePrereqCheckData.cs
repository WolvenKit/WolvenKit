using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqCheckData : CVariable
	{
		private CEnum<gameEPrerequisiteType> _prereqType;
		private CEnum<EComparisonType> _comparisonType;
		private CString _contextObject;
		private CFloat _valueToCompare;

		[Ordinal(0)] 
		[RED("prereqType")] 
		public CEnum<gameEPrerequisiteType> PrereqType
		{
			get
			{
				if (_prereqType == null)
				{
					_prereqType = (CEnum<gameEPrerequisiteType>) CR2WTypeManager.Create("gameEPrerequisiteType", "prereqType", cr2w, this);
				}
				return _prereqType;
			}
			set
			{
				if (_prereqType == value)
				{
					return;
				}
				_prereqType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contextObject")] 
		public CString ContextObject
		{
			get
			{
				if (_contextObject == null)
				{
					_contextObject = (CString) CR2WTypeManager.Create("String", "contextObject", cr2w, this);
				}
				return _contextObject;
			}
			set
			{
				if (_contextObject == value)
				{
					return;
				}
				_contextObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public gamePrereqCheckData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
