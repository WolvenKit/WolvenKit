using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitFromVehicle : AIVehicleTaskAbstract
	{
		private CBool _useFastExit;
		private CBool _tryBlendToWalk;

		[Ordinal(0)] 
		[RED("useFastExit")] 
		public CBool UseFastExit
		{
			get => GetProperty(ref _useFastExit);
			set => SetProperty(ref _useFastExit, value);
		}

		[Ordinal(1)] 
		[RED("tryBlendToWalk")] 
		public CBool TryBlendToWalk
		{
			get => GetProperty(ref _tryBlendToWalk);
			set => SetProperty(ref _tryBlendToWalk, value);
		}
	}
}
