using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVisualCustomizationComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("questSystem")] 
		public CHandle<questQuestsSystem> QuestSystem
		{
			get => GetPropertyValue<CHandle<questQuestsSystem>>();
			set => SetPropertyValue<CHandle<questQuestsSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("twitchDropFactNames")] 
		public CArray<CName> TwitchDropFactNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("twitchDropListenerIDs")] 
		public CArray<CUInt32> TwitchDropListenerIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public vehicleVisualCustomizationComponent()
		{
			TwitchDropFactNames = new();
			TwitchDropListenerIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
