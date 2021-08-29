using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStatListener : gameScriptStatsListener
	{
		private CWeakHandle<ScriptedPuppet> _owner;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get => GetProperty(ref _behaviorCallbackName);
			set => SetProperty(ref _behaviorCallbackName, value);
		}
	}
}
