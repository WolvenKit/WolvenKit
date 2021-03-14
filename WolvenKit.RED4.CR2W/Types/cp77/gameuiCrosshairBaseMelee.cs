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
			get
			{
				if (_meleeStateBlackboardId == null)
				{
					_meleeStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "meleeStateBlackboardId", cr2w, this);
				}
				return _meleeStateBlackboardId;
			}
			set
			{
				if (_meleeStateBlackboardId == value)
				{
					return;
				}
				_meleeStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("playerSMBB")] 
		public CHandle<gameIBlackboard> PlayerSMBB
		{
			get
			{
				if (_playerSMBB == null)
				{
					_playerSMBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerSMBB", cr2w, this);
				}
				return _playerSMBB;
			}
			set
			{
				if (_playerSMBB == value)
				{
					return;
				}
				_playerSMBB = value;
				PropertySet(this);
			}
		}

		public gameuiCrosshairBaseMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
