using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionTargetStates : CVariable
	{
		private AIActionNPCStates _npcStates;
		private AIActionPlayerStates _playerStates;

		[Ordinal(0)] 
		[RED("npcStates")] 
		public AIActionNPCStates NpcStates
		{
			get
			{
				if (_npcStates == null)
				{
					_npcStates = (AIActionNPCStates) CR2WTypeManager.Create("AIActionNPCStates", "npcStates", cr2w, this);
				}
				return _npcStates;
			}
			set
			{
				if (_npcStates == value)
				{
					return;
				}
				_npcStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerStates")] 
		public AIActionPlayerStates PlayerStates
		{
			get
			{
				if (_playerStates == null)
				{
					_playerStates = (AIActionPlayerStates) CR2WTypeManager.Create("AIActionPlayerStates", "playerStates", cr2w, this);
				}
				return _playerStates;
			}
			set
			{
				if (_playerStates == value)
				{
					return;
				}
				_playerStates = value;
				PropertySet(this);
			}
		}

		public AIActionTargetStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
