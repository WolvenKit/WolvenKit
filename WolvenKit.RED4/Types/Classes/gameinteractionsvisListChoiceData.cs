using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisListChoiceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		[Ordinal(2)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetPropertyValue<gameinteractionsChoiceCaption>();
			set => SetPropertyValue<gameinteractionsChoiceCaption>(value);
		}

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>();
			set => SetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>(value);
		}

		public gameinteractionsvisListChoiceData()
		{
			Type = new();
			CaptionParts = new() { Parts = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
