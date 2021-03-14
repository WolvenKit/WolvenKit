using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetHighLevelState : CVariable
	{
		private CBool _isDead;
		private CUInt32 _deathFrameId;

		[Ordinal(0)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get
			{
				if (_isDead == null)
				{
					_isDead = (CBool) CR2WTypeManager.Create("Bool", "isDead", cr2w, this);
				}
				return _isDead;
			}
			set
			{
				if (_isDead == value)
				{
					return;
				}
				_isDead = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deathFrameId")] 
		public CUInt32 DeathFrameId
		{
			get
			{
				if (_deathFrameId == null)
				{
					_deathFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "deathFrameId", cr2w, this);
				}
				return _deathFrameId;
			}
			set
			{
				if (_deathFrameId == value)
				{
					return;
				}
				_deathFrameId = value;
				PropertySet(this);
			}
		}

		public gameMuppetHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
