using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		private CString _displayNameOverride;
		private CBool _useLookAt;
		private CBool _disableAfterSelectingChoice;
		private CHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;
		private CUInt8 _hubPriority;

		[Ordinal(1)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetProperty(ref _displayNameOverride);
			set => SetProperty(ref _displayNameOverride, value);
		}

		[Ordinal(2)] 
		[RED("useLookAt")] 
		public CBool UseLookAt
		{
			get => GetProperty(ref _useLookAt);
			set => SetProperty(ref _useLookAt, value);
		}

		[Ordinal(3)] 
		[RED("disableAfterSelectingChoice")] 
		public CBool DisableAfterSelectingChoice
		{
			get => GetProperty(ref _disableAfterSelectingChoice);
			set => SetProperty(ref _disableAfterSelectingChoice, value);
		}

		[Ordinal(4)] 
		[RED("timeProvider")] 
		public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetProperty(ref _timeProvider);
			set => SetProperty(ref _timeProvider, value);
		}

		[Ordinal(5)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetProperty(ref _hubPriority);
			set => SetProperty(ref _hubPriority, value);
		}

		public gameinteractionsvisDialogVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
