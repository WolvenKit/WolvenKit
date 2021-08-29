using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModuleInstance : IScriptable
	{
		private CBool _isLookedAt;
		private CBool _isRevealed;
		private CBool _wasProcessed;
		private entEntityID _entityID;
		private CEnum<InstanceState> _state;
		private CHandle<ModuleInstance> _previousInstance;

		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}

		[Ordinal(1)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(2)] 
		[RED("wasProcessed")] 
		public CBool WasProcessed
		{
			get => GetProperty(ref _wasProcessed);
			set => SetProperty(ref _wasProcessed, value);
		}

		[Ordinal(3)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CEnum<InstanceState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(5)] 
		[RED("previousInstance")] 
		public CHandle<ModuleInstance> PreviousInstance
		{
			get => GetProperty(ref _previousInstance);
			set => SetProperty(ref _previousInstance, value);
		}
	}
}
