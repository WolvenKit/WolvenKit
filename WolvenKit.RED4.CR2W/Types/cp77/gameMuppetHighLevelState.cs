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
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(1)] 
		[RED("deathFrameId")] 
		public CUInt32 DeathFrameId
		{
			get => GetProperty(ref _deathFrameId);
			set => SetProperty(ref _deathFrameId, value);
		}

		public gameMuppetHighLevelState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
