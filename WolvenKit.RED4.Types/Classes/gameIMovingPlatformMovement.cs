using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMovingPlatformMovement : IScriptable
	{
		private gameIMovingPlatformMovementInitData _initData;

		[Ordinal(0)] 
		[RED("initData")] 
		public gameIMovingPlatformMovementInitData InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}
	}
}
