using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(1)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("useLookAt")] 
		public CBool UseLookAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("disableAfterSelectingChoice")] 
		public CBool DisableAfterSelectingChoice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetPropertyValue<CHandle<gameinteractionsvisIVisualizerTimeProvider>>();
			set => SetPropertyValue<CHandle<gameinteractionsvisIVisualizerTimeProvider>>(value);
		}

		[Ordinal(5)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameinteractionsvisDialogVisualizerDefinition()
		{
			UseLookAt = true;
			DisableAfterSelectingChoice = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
