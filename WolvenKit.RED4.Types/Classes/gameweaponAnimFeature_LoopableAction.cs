using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		private CFloat _loopDuration;
		private CUInt8 _numLoops;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get => GetProperty(ref _loopDuration);
			set => SetProperty(ref _loopDuration, value);
		}

		[Ordinal(1)] 
		[RED("numLoops")] 
		public CUInt8 NumLoops
		{
			get => GetProperty(ref _numLoops);
			set => SetProperty(ref _numLoops, value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
