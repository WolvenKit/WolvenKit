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
			get => GetProperty(ref _equipEvent);
			set => SetProperty(ref _equipEvent, value);
		}

		[Ordinal(1)] 
		[RED("unequipStartedEvent")] 
		public CName UnequipStartedEvent
		{
			get => GetProperty(ref _unequipStartedEvent);
			set => SetProperty(ref _unequipStartedEvent, value);
		}

		[Ordinal(2)] 
		[RED("unequippedEvent")] 
		public CName UnequippedEvent
		{
			get => GetProperty(ref _unequippedEvent);
			set => SetProperty(ref _unequippedEvent, value);
		}

		public audioWeaponHandlingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
