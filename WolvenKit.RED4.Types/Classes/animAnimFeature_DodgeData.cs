using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_DodgeData : animAnimFeature
	{
		private CInt32 _dodgeType;
		private CInt32 _dodgeDirection;

		[Ordinal(0)] 
		[RED("dodgeType")] 
		public CInt32 DodgeType
		{
			get => GetProperty(ref _dodgeType);
			set => SetProperty(ref _dodgeType, value);
		}

		[Ordinal(1)] 
		[RED("dodgeDirection")] 
		public CInt32 DodgeDirection
		{
			get => GetProperty(ref _dodgeDirection);
			set => SetProperty(ref _dodgeDirection, value);
		}
	}
}
