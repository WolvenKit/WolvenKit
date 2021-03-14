using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestSecuritySystemInput : redEvent
	{
		private CEnum<SecurityEventScopeSettings> _notificationScope;
		private CArray<NPCReference> _notifySpecificNPCs;
		private RevealPlayerSettings _revealPlayerSettings;

		[Ordinal(0)] 
		[RED("notificationScope")] 
		public CEnum<SecurityEventScopeSettings> NotificationScope
		{
			get
			{
				if (_notificationScope == null)
				{
					_notificationScope = (CEnum<SecurityEventScopeSettings>) CR2WTypeManager.Create("SecurityEventScopeSettings", "notificationScope", cr2w, this);
				}
				return _notificationScope;
			}
			set
			{
				if (_notificationScope == value)
				{
					return;
				}
				_notificationScope = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("notifySpecificNPCs")] 
		public CArray<NPCReference> NotifySpecificNPCs
		{
			get
			{
				if (_notifySpecificNPCs == null)
				{
					_notifySpecificNPCs = (CArray<NPCReference>) CR2WTypeManager.Create("array:NPCReference", "notifySpecificNPCs", cr2w, this);
				}
				return _notifySpecificNPCs;
			}
			set
			{
				if (_notifySpecificNPCs == value)
				{
					return;
				}
				_notifySpecificNPCs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get
			{
				if (_revealPlayerSettings == null)
				{
					_revealPlayerSettings = (RevealPlayerSettings) CR2WTypeManager.Create("RevealPlayerSettings", "revealPlayerSettings", cr2w, this);
				}
				return _revealPlayerSettings;
			}
			set
			{
				if (_revealPlayerSettings == value)
				{
					return;
				}
				_revealPlayerSettings = value;
				PropertySet(this);
			}
		}

		public QuestSecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
