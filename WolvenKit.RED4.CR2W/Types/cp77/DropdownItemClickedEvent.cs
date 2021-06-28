using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownItemClickedEvent : redEvent
	{
		private wCHandle<IScriptable> _owner;
		private wCHandle<DropdownButtonController> _triggerButton;
		private CVariant _identifier;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<IScriptable> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("triggerButton")] 
		public wCHandle<DropdownButtonController> TriggerButton
		{
			get => GetProperty(ref _triggerButton);
			set => SetProperty(ref _triggerButton, value);
		}

		[Ordinal(2)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		public DropdownItemClickedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
