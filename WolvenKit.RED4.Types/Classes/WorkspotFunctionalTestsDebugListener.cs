using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorkspotFunctionalTestsDebugListener : IScriptable
	{
		private entEntityID _entityId;
		private CInt32 _instancesCreated;
		private CInt32 _instancesRemoved;
		private CInt32 _workspotsSetup;
		private CInt32 _workspotsStarted;
		private CInt32 _workspotsFinished;
		private CArray<CString> _animationsStack;
		private CArray<CString> _animationsSkippedStack;
		private CArray<CString> _animationsMissingStack;
		private CInt32 _skipOverflows;
		private CInt32 _teleportRequests;
		private CInt32 _movementRequests;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("instancesCreated")] 
		public CInt32 InstancesCreated
		{
			get => GetProperty(ref _instancesCreated);
			set => SetProperty(ref _instancesCreated, value);
		}

		[Ordinal(2)] 
		[RED("instancesRemoved")] 
		public CInt32 InstancesRemoved
		{
			get => GetProperty(ref _instancesRemoved);
			set => SetProperty(ref _instancesRemoved, value);
		}

		[Ordinal(3)] 
		[RED("workspotsSetup")] 
		public CInt32 WorkspotsSetup
		{
			get => GetProperty(ref _workspotsSetup);
			set => SetProperty(ref _workspotsSetup, value);
		}

		[Ordinal(4)] 
		[RED("workspotsStarted")] 
		public CInt32 WorkspotsStarted
		{
			get => GetProperty(ref _workspotsStarted);
			set => SetProperty(ref _workspotsStarted, value);
		}

		[Ordinal(5)] 
		[RED("workspotsFinished")] 
		public CInt32 WorkspotsFinished
		{
			get => GetProperty(ref _workspotsFinished);
			set => SetProperty(ref _workspotsFinished, value);
		}

		[Ordinal(6)] 
		[RED("animationsStack")] 
		public CArray<CString> AnimationsStack
		{
			get => GetProperty(ref _animationsStack);
			set => SetProperty(ref _animationsStack, value);
		}

		[Ordinal(7)] 
		[RED("animationsSkippedStack")] 
		public CArray<CString> AnimationsSkippedStack
		{
			get => GetProperty(ref _animationsSkippedStack);
			set => SetProperty(ref _animationsSkippedStack, value);
		}

		[Ordinal(8)] 
		[RED("animationsMissingStack")] 
		public CArray<CString> AnimationsMissingStack
		{
			get => GetProperty(ref _animationsMissingStack);
			set => SetProperty(ref _animationsMissingStack, value);
		}

		[Ordinal(9)] 
		[RED("skipOverflows")] 
		public CInt32 SkipOverflows
		{
			get => GetProperty(ref _skipOverflows);
			set => SetProperty(ref _skipOverflows, value);
		}

		[Ordinal(10)] 
		[RED("teleportRequests")] 
		public CInt32 TeleportRequests
		{
			get => GetProperty(ref _teleportRequests);
			set => SetProperty(ref _teleportRequests, value);
		}

		[Ordinal(11)] 
		[RED("movementRequests")] 
		public CInt32 MovementRequests
		{
			get => GetProperty(ref _movementRequests);
			set => SetProperty(ref _movementRequests, value);
		}
	}
}
