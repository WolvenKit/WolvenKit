using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisDeviceVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		private CEnum<gameinteractionsvisInteractionType> _interactionType;
		private CString _displayNameOverride;
		private CBool _useDefaultActionMapping;
		private CBool _createMappin;
		private CBool _isDynamic;
		private CHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

		[Ordinal(1)] 
		[RED("interactionType")] 
		public CEnum<gameinteractionsvisInteractionType> InteractionType
		{
			get => GetProperty(ref _interactionType);
			set => SetProperty(ref _interactionType, value);
		}

		[Ordinal(2)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetProperty(ref _displayNameOverride);
			set => SetProperty(ref _displayNameOverride, value);
		}

		[Ordinal(3)] 
		[RED("useDefaultActionMapping")] 
		public CBool UseDefaultActionMapping
		{
			get => GetProperty(ref _useDefaultActionMapping);
			set => SetProperty(ref _useDefaultActionMapping, value);
		}

		[Ordinal(4)] 
		[RED("createMappin")] 
		public CBool CreateMappin
		{
			get => GetProperty(ref _createMappin);
			set => SetProperty(ref _createMappin, value);
		}

		[Ordinal(5)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetProperty(ref _isDynamic);
			set => SetProperty(ref _isDynamic, value);
		}

		[Ordinal(6)] 
		[RED("timeProvider")] 
		public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetProperty(ref _timeProvider);
			set => SetProperty(ref _timeProvider, value);
		}

		public gameinteractionsvisDeviceVisualizerDefinition()
		{
			_isDynamic = true;
		}
	}
}
