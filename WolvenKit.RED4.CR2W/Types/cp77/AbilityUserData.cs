using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbilityUserData : IScriptable
	{
		private TweakDBID _abilityID;
		private CName _locKeyName;
		private wCHandle<inkAsyncSpawnRequest> _asyncSpawnRequest;

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
		public wCHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetProperty(ref _asyncSpawnRequest);
			set => SetProperty(ref _asyncSpawnRequest, value);
		}

		public AbilityUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
