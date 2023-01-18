using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisListChoiceHubData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("activityState")] 
		public CEnum<gameinteractionsvisEVisualizerActivityState> ActivityState
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisEVisualizerActivityState>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisEVisualizerActivityState>>(value);
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>(value);
		}

		[Ordinal(3)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisListChoiceData> Choices
		{
			get => GetPropertyValue<CArray<gameinteractionsvisListChoiceData>>();
			set => SetPropertyValue<CArray<gameinteractionsvisListChoiceData>>(value);
		}

		[Ordinal(6)] 
		[RED("timeProvider")] 
		public CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>();
			set => SetPropertyValue<CWeakHandle<gameinteractionsvisIVisualizerTimeProvider>>(value);
		}

		[Ordinal(7)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameinteractionsvisListChoiceHubData()
		{
			Id = -1;
			Choices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
