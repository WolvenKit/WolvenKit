using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SFocusModeOperationData : CVariable
	{
		private CEnum<ETriggerOperationType> _operationType;
		private CBool _isLookedAt;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<ETriggerOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<ETriggerOperationType>) CR2WTypeManager.Create("ETriggerOperationType", "operationType", cr2w, this);
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

		[Ordinal(1)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get
			{
				if (_isLookedAt == null)
				{
					_isLookedAt = (CBool) CR2WTypeManager.Create("Bool", "isLookedAt", cr2w, this);
				}
				return _isLookedAt;
			}
			set
			{
				if (_isLookedAt == value)
				{
					return;
				}
				_isLookedAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (SBaseDeviceOperationData) CR2WTypeManager.Create("SBaseDeviceOperationData", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public SFocusModeOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
