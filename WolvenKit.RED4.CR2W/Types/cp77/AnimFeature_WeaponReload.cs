using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReload : animAnimFeature
	{
		private CBool _emptyReload;
		private CInt32 _amountToReload;
		private CBool _continueLoop;
		private CFloat _loopDuration;
		private CFloat _emptyDuration;

		[Ordinal(0)] 
		[RED("emptyReload")] 
		public CBool EmptyReload
		{
			get => GetProperty(ref _emptyReload);
			set => SetProperty(ref _emptyReload, value);
		}

		[Ordinal(1)] 
		[RED("amountToReload")] 
		public CInt32 AmountToReload
		{
			get => GetProperty(ref _amountToReload);
			set => SetProperty(ref _amountToReload, value);
		}

		[Ordinal(2)] 
		[RED("continueLoop")] 
		public CBool ContinueLoop
		{
			get => GetProperty(ref _continueLoop);
			set => SetProperty(ref _continueLoop, value);
		}

		[Ordinal(3)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get => GetProperty(ref _loopDuration);
			set => SetProperty(ref _loopDuration, value);
		}

		[Ordinal(4)] 
		[RED("emptyDuration")] 
		public CFloat EmptyDuration
		{
			get => GetProperty(ref _emptyDuration);
			set => SetProperty(ref _emptyDuration, value);
		}

		public AnimFeature_WeaponReload(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
