using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillerUIEvent : redEvent
	{
		private gameinteractionsChoice _actionChosen;
		private CWeakHandle<gameObject> _activator;

		[Ordinal(0)] 
		[RED("actionChosen")] 
		public gameinteractionsChoice ActionChosen
		{
			get => GetProperty(ref _actionChosen);
			set => SetProperty(ref _actionChosen, value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}
	}
}
