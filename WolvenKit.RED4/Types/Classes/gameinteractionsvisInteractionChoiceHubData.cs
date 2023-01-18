using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisInteractionChoiceHubData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>(value);
		}

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get => GetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>();
			set => SetPropertyValue<CArray<gameinteractionsvisInteractionChoiceData>>(value);
		}

		[Ordinal(5)] 
		[RED("timeProvider")] 
		public CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>();
			set => SetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>(value);
		}

		public gameinteractionsvisInteractionChoiceHubData()
		{
			Id = -1;
			Choices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
