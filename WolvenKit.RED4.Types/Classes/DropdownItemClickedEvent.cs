using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropdownItemClickedEvent : redEvent
	{
		private CWeakHandle<IScriptable> _owner;
		private CWeakHandle<DropdownButtonController> _triggerButton;
		private CVariant _identifier;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<IScriptable> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("triggerButton")] 
		public CWeakHandle<DropdownButtonController> TriggerButton
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
	}
}
