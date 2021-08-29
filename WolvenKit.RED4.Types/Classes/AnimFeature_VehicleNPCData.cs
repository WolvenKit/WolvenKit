using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_VehicleNPCData : animAnimFeature
	{
		private CBool _isDriver;
		private CInt32 _side;

		[Ordinal(0)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get => GetProperty(ref _isDriver);
			set => SetProperty(ref _isDriver, value);
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}
	}
}
