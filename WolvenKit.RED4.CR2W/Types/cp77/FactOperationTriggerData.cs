using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactOperationTriggerData : DeviceOperationTriggerData
	{
		private CEnum<EComparisonOperator> _comparisionType;
		private CName _factName;
		private CInt32 _factValue;
		private CUInt32 _callbackID;

		[Ordinal(1)] 
		[RED("comparisionType")] 
		public CEnum<EComparisonOperator> ComparisionType
		{
			get
			{
				if (_comparisionType == null)
				{
					_comparisionType = (CEnum<EComparisonOperator>) CR2WTypeManager.Create("EComparisonOperator", "comparisionType", cr2w, this);
				}
				return _comparisionType;
			}
			set
			{
				if (_comparisionType == value)
				{
					return;
				}
				_comparisionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get
			{
				if (_callbackID == null)
				{
					_callbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackID", cr2w, this);
				}
				return _callbackID;
			}
			set
			{
				if (_callbackID == value)
				{
					return;
				}
				_callbackID = value;
				PropertySet(this);
			}
		}

		public FactOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
