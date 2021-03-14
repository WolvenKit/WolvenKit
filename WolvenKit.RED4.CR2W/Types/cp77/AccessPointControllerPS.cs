using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessPointControllerPS : MasterControllerPS
	{
		private CArray<CString> _rewardNotificationIcons;
		private CString _rewardNotificationString;
		private CHandle<HackingContainer> _accessPointSkillChecks;
		private CBool _isBreached;
		private CBool _isVirtual;

		[Ordinal(104)] 
		[RED("rewardNotificationIcons")] 
		public CArray<CString> RewardNotificationIcons
		{
			get
			{
				if (_rewardNotificationIcons == null)
				{
					_rewardNotificationIcons = (CArray<CString>) CR2WTypeManager.Create("array:String", "rewardNotificationIcons", cr2w, this);
				}
				return _rewardNotificationIcons;
			}
			set
			{
				if (_rewardNotificationIcons == value)
				{
					return;
				}
				_rewardNotificationIcons = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("rewardNotificationString")] 
		public CString RewardNotificationString
		{
			get
			{
				if (_rewardNotificationString == null)
				{
					_rewardNotificationString = (CString) CR2WTypeManager.Create("String", "rewardNotificationString", cr2w, this);
				}
				return _rewardNotificationString;
			}
			set
			{
				if (_rewardNotificationString == value)
				{
					return;
				}
				_rewardNotificationString = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("accessPointSkillChecks")] 
		public CHandle<HackingContainer> AccessPointSkillChecks
		{
			get
			{
				if (_accessPointSkillChecks == null)
				{
					_accessPointSkillChecks = (CHandle<HackingContainer>) CR2WTypeManager.Create("handle:HackingContainer", "accessPointSkillChecks", cr2w, this);
				}
				return _accessPointSkillChecks;
			}
			set
			{
				if (_accessPointSkillChecks == value)
				{
					return;
				}
				_accessPointSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get
			{
				if (_isBreached == null)
				{
					_isBreached = (CBool) CR2WTypeManager.Create("Bool", "isBreached", cr2w, this);
				}
				return _isBreached;
			}
			set
			{
				if (_isBreached == value)
				{
					return;
				}
				_isBreached = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("isVirtual")] 
		public CBool IsVirtual
		{
			get
			{
				if (_isVirtual == null)
				{
					_isVirtual = (CBool) CR2WTypeManager.Create("Bool", "isVirtual", cr2w, this);
				}
				return _isVirtual;
			}
			set
			{
				if (_isVirtual == value)
				{
					return;
				}
				_isVirtual = value;
				PropertySet(this);
			}
		}

		public AccessPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
