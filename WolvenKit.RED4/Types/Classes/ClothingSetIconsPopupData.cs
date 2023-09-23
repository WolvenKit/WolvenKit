using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetIconsPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("IconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("IconChanged")] 
		public CBool IconChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("IconIDs")] 
		public CArray<TweakDBID> IconIDs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public ClothingSetIconsPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
