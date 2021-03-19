using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		private CBool _isBackfaceImpact;
		private CBool _noAudio;
		private CBool _isMeleeAttack;

		[Ordinal(1)] 
		[RED("isBackfaceImpact")] 
		public CBool IsBackfaceImpact
		{
			get => GetProperty(ref _isBackfaceImpact);
			set => SetProperty(ref _isBackfaceImpact, value);
		}

		[Ordinal(2)] 
		[RED("noAudio")] 
		public CBool NoAudio
		{
			get => GetProperty(ref _noAudio);
			set => SetProperty(ref _noAudio, value);
		}

		[Ordinal(3)] 
		[RED("isMeleeAttack")] 
		public CBool IsMeleeAttack
		{
			get => GetProperty(ref _isMeleeAttack);
			set => SetProperty(ref _isMeleeAttack, value);
		}

		public gameEffectExecutor_BulletImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
