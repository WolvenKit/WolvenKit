using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsFacingTowardsSource : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _applyForPlayer;
		private CBool _applyForNPCs;
		private CBool _invert;
		private CFloat _maxAllowedAngleYaw;
		private CFloat _maxAllowedAnglePitch;

		[Ordinal(0)] 
		[RED("applyForPlayer")] 
		public CBool ApplyForPlayer
		{
			get => GetProperty(ref _applyForPlayer);
			set => SetProperty(ref _applyForPlayer, value);
		}

		[Ordinal(1)] 
		[RED("applyForNPCs")] 
		public CBool ApplyForNPCs
		{
			get => GetProperty(ref _applyForNPCs);
			set => SetProperty(ref _applyForNPCs, value);
		}

		[Ordinal(2)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(3)] 
		[RED("maxAllowedAngleYaw")] 
		public CFloat MaxAllowedAngleYaw
		{
			get => GetProperty(ref _maxAllowedAngleYaw);
			set => SetProperty(ref _maxAllowedAngleYaw, value);
		}

		[Ordinal(4)] 
		[RED("maxAllowedAnglePitch")] 
		public CFloat MaxAllowedAnglePitch
		{
			get => GetProperty(ref _maxAllowedAnglePitch);
			set => SetProperty(ref _maxAllowedAnglePitch, value);
		}
	}
}
