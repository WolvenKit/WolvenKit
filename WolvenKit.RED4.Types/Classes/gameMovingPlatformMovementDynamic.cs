using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformMovementDynamic : gameIMovingPlatformMovementPointToPoint
	{
		private CName _curveName;

		[Ordinal(1)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get => GetProperty(ref _curveName);
			set => SetProperty(ref _curveName, value);
		}
	}
}
