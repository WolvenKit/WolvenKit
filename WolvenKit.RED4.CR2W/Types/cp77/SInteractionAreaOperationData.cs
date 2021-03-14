using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInteractionAreaOperationData : CVariable
	{
		private CBool _isActivatorPlayer;
		private CBool _isActivatorNPC;
		private CName _areaTag;
		private CEnum<gameinteractionsEInteractionEventType> _operationType;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get
			{
				if (_isActivatorPlayer == null)
				{
					_isActivatorPlayer = (CBool) CR2WTypeManager.Create("Bool", "isActivatorPlayer", cr2w, this);
				}
				return _isActivatorPlayer;
			}
			set
			{
				if (_isActivatorPlayer == value)
				{
					return;
				}
				_isActivatorPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get
			{
				if (_isActivatorNPC == null)
				{
					_isActivatorNPC = (CBool) CR2WTypeManager.Create("Bool", "isActivatorNPC", cr2w, this);
				}
				return _isActivatorNPC;
			}
			set
			{
				if (_isActivatorNPC == value)
				{
					return;
				}
				_isActivatorNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("areaTag")] 
		public CName AreaTag
		{
			get
			{
				if (_areaTag == null)
				{
					_areaTag = (CName) CR2WTypeManager.Create("CName", "areaTag", cr2w, this);
				}
				return _areaTag;
			}
			set
			{
				if (_areaTag == value)
				{
					return;
				}
				_areaTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<gameinteractionsEInteractionEventType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<gameinteractionsEInteractionEventType>) CR2WTypeManager.Create("gameinteractionsEInteractionEventType", "operationType", cr2w, this);
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

		[Ordinal(4)] 
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

		public SInteractionAreaOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
