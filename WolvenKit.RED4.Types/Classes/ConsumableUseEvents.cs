using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumableUseEvents : ConsumableTransitions
	{
		private CBool _effectsApplied;
		private CBool _modelRemoved;
		private gameItemID _activeConsumable;

		[Ordinal(0)] 
		[RED("effectsApplied")] 
		public CBool EffectsApplied
		{
			get => GetProperty(ref _effectsApplied);
			set => SetProperty(ref _effectsApplied, value);
		}

		[Ordinal(1)] 
		[RED("modelRemoved")] 
		public CBool ModelRemoved
		{
			get => GetProperty(ref _modelRemoved);
			set => SetProperty(ref _modelRemoved, value);
		}

		[Ordinal(2)] 
		[RED("activeConsumable")] 
		public gameItemID ActiveConsumable
		{
			get => GetProperty(ref _activeConsumable);
			set => SetProperty(ref _activeConsumable, value);
		}
	}
}
