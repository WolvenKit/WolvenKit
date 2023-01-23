using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorkspotFunctionalTestsDebugListener : IScriptable
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("instancesCreated")] 
		public CInt32 InstancesCreated
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("instancesRemoved")] 
		public CInt32 InstancesRemoved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("workspotsSetup")] 
		public CInt32 WorkspotsSetup
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("workspotsStarted")] 
		public CInt32 WorkspotsStarted
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("workspotsFinished")] 
		public CInt32 WorkspotsFinished
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("animationsStack")] 
		public CArray<CString> AnimationsStack
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(7)] 
		[RED("animationsSkippedStack")] 
		public CArray<CString> AnimationsSkippedStack
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(8)] 
		[RED("animationsMissingStack")] 
		public CArray<CString> AnimationsMissingStack
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(9)] 
		[RED("skipOverflows")] 
		public CInt32 SkipOverflows
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("teleportRequests")] 
		public CInt32 TeleportRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("movementRequests")] 
		public CInt32 MovementRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WorkspotFunctionalTestsDebugListener()
		{
			EntityId = new();
			AnimationsStack = new();
			AnimationsSkippedStack = new();
			AnimationsMissingStack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
