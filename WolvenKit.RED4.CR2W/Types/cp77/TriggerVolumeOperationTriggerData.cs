using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperationTriggerData : DeviceOperationTriggerData
	{
		private CBool _isActivatorPlayer;
		private CBool _isActivatorNPC;
		private CName _componentName;
		private CEnum<ETriggerOperationType> _operationType;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public TriggerVolumeOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
