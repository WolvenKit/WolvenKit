using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceCLSStateRequest : gameScriptableSystemRequest
	{
		private CEnum<ECLSForcedState> _state;
		private CName _sourceName;
		private CEnum<EPriority> _priority;
		private CBool _removePreviousRequests;
		private CBool _savable;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(3)] 
		[RED("removePreviousRequests")] 
		public CBool RemovePreviousRequests
		{
			get => GetProperty(ref _removePreviousRequests);
			set => SetProperty(ref _removePreviousRequests, value);
		}

		[Ordinal(4)] 
		[RED("savable")] 
		public CBool Savable
		{
			get => GetProperty(ref _savable);
			set => SetProperty(ref _savable, value);
		}
	}
}
