using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponHandlingSettings : CVariable
	{
		private CName _equipEvent;
		private CName _unequipStartedEvent;
		private CName _unequippedEvent;

		[Ordinal(0)] 
		[RED("equipEvent")] 
		public CName EquipEvent
		{
			get
			{
				if (_equipEvent == null)
				{
					_equipEvent = (CName) CR2WTypeManager.Create("CName", "equipEvent", cr2w, this);
				}
				return _equipEvent;
			}
			set
			{
				if (_equipEvent == value)
				{
					return;
				}
				_equipEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unequipStartedEvent")] 
		public CName UnequipStartedEvent
		{
			get
			{
				if (_unequipStartedEvent == null)
				{
					_unequipStartedEvent = (CName) CR2WTypeManager.Create("CName", "unequipStartedEvent", cr2w, this);
				}
				return _unequipStartedEvent;
			}
			set
			{
				if (_unequipStartedEvent == value)
				{
					return;
				}
				_unequipStartedEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unequippedEvent")] 
		public CName UnequippedEvent
		{
			get
			{
				if (_unequippedEvent == null)
				{
					_unequippedEvent = (CName) CR2WTypeManager.Create("CName", "unequippedEvent", cr2w, this);
				}
				return _unequippedEvent;
			}
			set
			{
				if (_unequippedEvent == value)
				{
					return;
				}
				_unequippedEvent = value;
				PropertySet(this);
			}
		}

		public audioWeaponHandlingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
