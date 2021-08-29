using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetJammedEvent : redEvent
	{
		private CBool _newJammedState;
		private CWeakHandle<gameweaponObject> _instigator;

		[Ordinal(0)] 
		[RED("newJammedState")] 
		public CBool NewJammedState
		{
			get => GetProperty(ref _newJammedState);
			set => SetProperty(ref _newJammedState, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameweaponObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}
	}
}
