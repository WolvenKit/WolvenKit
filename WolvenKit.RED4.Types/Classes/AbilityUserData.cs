using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbilityUserData : IScriptable
	{
		private TweakDBID _abilityID;
		private CName _locKeyName;
		private CWeakHandle<inkAsyncSpawnRequest> _asyncSpawnRequest;

		[Ordinal(0)] 
		[RED("abilityID")] 
		public TweakDBID AbilityID
		{
			get => GetProperty(ref _abilityID);
			set => SetProperty(ref _abilityID, value);
		}

		[Ordinal(1)] 
		[RED("locKeyName")] 
		public CName LocKeyName
		{
			get => GetProperty(ref _locKeyName);
			set => SetProperty(ref _locKeyName, value);
		}

		[Ordinal(2)] 
		[RED("asyncSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetProperty(ref _asyncSpawnRequest);
			set => SetProperty(ref _asyncSpawnRequest, value);
		}
	}
}
