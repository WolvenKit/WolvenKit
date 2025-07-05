using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("gameRestrictionIDs")] 
		public CArray<TweakDBID> GameRestrictionIDs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(4)] 
		[RED("treatAsInterior")] 
		public CBool TreatAsInterior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("setTier2")] 
		public CBool SetTier2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldInteriorAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
			GameRestrictionIDs = new() { "GameplayRestriction.NoTimeSkip" };
			TreatAsInterior = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
