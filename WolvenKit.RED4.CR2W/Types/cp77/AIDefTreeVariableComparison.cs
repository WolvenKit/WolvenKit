using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDefTreeVariableComparison : LibTreeDefTreeVariableBoolBase
	{
		private CBool _exportAsProperty;
		private CUInt16 _referenceVariableId;
		private CName _referenceVariableName;
		private CName _referenceVariableShortName;
		private CName _referenceType;
		private CEnum<EComparisonType> _operator;
		private CVariant _referenceValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get
			{
				if (_exportAsProperty == null)
				{
					_exportAsProperty = (CBool) CR2WTypeManager.Create("Bool", "exportAsProperty", cr2w, this);
				}
				return _exportAsProperty;
			}
			set
			{
				if (_exportAsProperty == value)
				{
					return;
				}
				_exportAsProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("referenceVariableId")] 
		public CUInt16 ReferenceVariableId
		{
			get
			{
				if (_referenceVariableId == null)
				{
					_referenceVariableId = (CUInt16) CR2WTypeManager.Create("Uint16", "referenceVariableId", cr2w, this);
				}
				return _referenceVariableId;
			}
			set
			{
				if (_referenceVariableId == value)
				{
					return;
				}
				_referenceVariableId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("referenceVariableName")] 
		public CName ReferenceVariableName
		{
			get
			{
				if (_referenceVariableName == null)
				{
					_referenceVariableName = (CName) CR2WTypeManager.Create("CName", "referenceVariableName", cr2w, this);
				}
				return _referenceVariableName;
			}
			set
			{
				if (_referenceVariableName == value)
				{
					return;
				}
				_referenceVariableName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("referenceVariableShortName")] 
		public CName ReferenceVariableShortName
		{
			get
			{
				if (_referenceVariableShortName == null)
				{
					_referenceVariableShortName = (CName) CR2WTypeManager.Create("CName", "referenceVariableShortName", cr2w, this);
				}
				return _referenceVariableShortName;
			}
			set
			{
				if (_referenceVariableShortName == value)
				{
					return;
				}
				_referenceVariableShortName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("referenceType")] 
		public CName ReferenceType
		{
			get
			{
				if (_referenceType == null)
				{
					_referenceType = (CName) CR2WTypeManager.Create("CName", "referenceType", cr2w, this);
				}
				return _referenceType;
			}
			set
			{
				if (_referenceType == value)
				{
					return;
				}
				_referenceType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("operator")] 
		public CEnum<EComparisonType> Operator
		{
			get
			{
				if (_operator == null)
				{
					_operator = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "operator", cr2w, this);
				}
				return _operator;
			}
			set
			{
				if (_operator == value)
				{
					return;
				}
				_operator = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("referenceValue")] 
		public CVariant ReferenceValue
		{
			get
			{
				if (_referenceValue == null)
				{
					_referenceValue = (CVariant) CR2WTypeManager.Create("Variant", "referenceValue", cr2w, this);
				}
				return _referenceValue;
			}
			set
			{
				if (_referenceValue == value)
				{
					return;
				}
				_referenceValue = value;
				PropertySet(this);
			}
		}

		public AIDefTreeVariableComparison(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
