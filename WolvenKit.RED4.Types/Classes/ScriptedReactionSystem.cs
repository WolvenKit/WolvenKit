using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptedReactionSystem : gameScriptableSystem
	{
		private CInt32 _fleeingNPCs;
		private CArray<CWeakHandle<entEntity>> _runners;
		private CFloat _registeredTimeout;
		private CBool _callInAction;
		private CWeakHandle<entEntity> _policeCaller;

		[Ordinal(0)] 
		[RED("fleeingNPCs")] 
		public CInt32 FleeingNPCs
		{
			get => GetProperty(ref _fleeingNPCs);
			set => SetProperty(ref _fleeingNPCs, value);
		}

		[Ordinal(1)] 
		[RED("runners")] 
		public CArray<CWeakHandle<entEntity>> Runners
		{
			get => GetProperty(ref _runners);
			set => SetProperty(ref _runners, value);
		}

		[Ordinal(2)] 
		[RED("registeredTimeout")] 
		public CFloat RegisteredTimeout
		{
			get => GetProperty(ref _registeredTimeout);
			set => SetProperty(ref _registeredTimeout, value);
		}

		[Ordinal(3)] 
		[RED("callInAction")] 
		public CBool CallInAction
		{
			get => GetProperty(ref _callInAction);
			set => SetProperty(ref _callInAction, value);
		}

		[Ordinal(4)] 
		[RED("policeCaller")] 
		public CWeakHandle<entEntity> PoliceCaller
		{
			get => GetProperty(ref _policeCaller);
			set => SetProperty(ref _policeCaller, value);
		}
	}
}
