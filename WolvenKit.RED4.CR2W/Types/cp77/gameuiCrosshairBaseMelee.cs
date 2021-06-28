using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		private CUInt32 _meleeStateBlackboardId;
		private CHandle<gameIBlackboard> _playerSMBB;

		[Ordinal(18)] 
		[RED("meleeStateBlackboardId")] 
		public CUInt32 MeleeStateBlackboardId
		{
			get => GetProperty(ref _meleeStateBlackboardId);
			set => SetProperty(ref _meleeStateBlackboardId, value);
		}

		[Ordinal(19)] 
		[RED("playerSMBB")] 
		public CHandle<gameIBlackboard> PlayerSMBB
		{
			get => GetProperty(ref _playerSMBB);
			set => SetProperty(ref _playerSMBB, value);
		}

		public gameuiCrosshairBaseMelee(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
