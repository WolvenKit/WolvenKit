using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystemSharedState : gameIGameSystemReplicatedState
	{
		private CArray<CHandle<gamedamageServerHitData>> _hitHistory;
		private CArray<CHandle<gamedamageServerKillData>> _killHistory;

		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<CHandle<gamedamageServerHitData>> HitHistory
		{
			get
			{
				if (_hitHistory == null)
				{
					_hitHistory = (CArray<CHandle<gamedamageServerHitData>>) CR2WTypeManager.Create("array:handle:gamedamageServerHitData", "hitHistory", cr2w, this);
				}
				return _hitHistory;
			}
			set
			{
				if (_hitHistory == value)
				{
					return;
				}
				_hitHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("killHistory")] 
		public CArray<CHandle<gamedamageServerKillData>> KillHistory
		{
			get
			{
				if (_killHistory == null)
				{
					_killHistory = (CArray<CHandle<gamedamageServerKillData>>) CR2WTypeManager.Create("array:handle:gamedamageServerKillData", "killHistory", cr2w, this);
				}
				return _killHistory;
			}
			set
			{
				if (_killHistory == value)
				{
					return;
				}
				_killHistory = value;
				PropertySet(this);
			}
		}

		public gameDamageSystemSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
