using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		private CArray<TweakDBID> _gameRestrictionIDs;
		private CBool _treatAsInterior;
		private CBool _setTier2;

		[Ordinal(3)] 
		[RED("gameRestrictionIDs")] 
		public CArray<TweakDBID> GameRestrictionIDs
		{
			get => GetProperty(ref _gameRestrictionIDs);
			set => SetProperty(ref _gameRestrictionIDs, value);
		}

		[Ordinal(4)] 
		[RED("treatAsInterior")] 
		public CBool TreatAsInterior
		{
			get => GetProperty(ref _treatAsInterior);
			set => SetProperty(ref _treatAsInterior, value);
		}

		[Ordinal(5)] 
		[RED("setTier2")] 
		public CBool SetTier2
		{
			get => GetProperty(ref _setTier2);
			set => SetProperty(ref _setTier2, value);
		}
	}
}
