using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DischargeEvents : WeaponEventsTransition
	{
		private CUInt32 _layerId;
		private CHandle<gameStatPoolsSystem> _statPoolsSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private entEntityID _weaponID;

		[Ordinal(0)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get => GetProperty(ref _layerId);
			set => SetProperty(ref _layerId, value);
		}

		[Ordinal(1)] 
		[RED("statPoolsSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolsSystem
		{
			get => GetProperty(ref _statPoolsSystem);
			set => SetProperty(ref _statPoolsSystem, value);
		}

		[Ordinal(2)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(3)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		public DischargeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
