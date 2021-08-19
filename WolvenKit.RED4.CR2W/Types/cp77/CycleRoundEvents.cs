using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CycleRoundEvents : WeaponEventsTransition
	{
		private CBool _hasBlockedAiming;
		private CFloat _blockAimStart;
		private CFloat _blockAimDuration;

		[Ordinal(3)] 
		[RED("hasBlockedAiming")] 
		public CBool HasBlockedAiming
		{
			get => GetProperty(ref _hasBlockedAiming);
			set => SetProperty(ref _hasBlockedAiming, value);
		}

		[Ordinal(4)] 
		[RED("blockAimStart")] 
		public CFloat BlockAimStart
		{
			get => GetProperty(ref _blockAimStart);
			set => SetProperty(ref _blockAimStart, value);
		}

		[Ordinal(5)] 
		[RED("blockAimDuration")] 
		public CFloat BlockAimDuration
		{
			get => GetProperty(ref _blockAimDuration);
			set => SetProperty(ref _blockAimDuration, value);
		}

		public CycleRoundEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
