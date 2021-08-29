using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetHighLevelState : RedBaseClass
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
	}
}
