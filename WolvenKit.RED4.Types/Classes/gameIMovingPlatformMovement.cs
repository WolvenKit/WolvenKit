using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMovingPlatformMovement : IScriptable
	{
		[Ordinal(0)] 
		[RED("initData")] 
		public gameIMovingPlatformMovementInitData InitData
		{
			get => GetPropertyValue<gameIMovingPlatformMovementInitData>();
			set => SetPropertyValue<gameIMovingPlatformMovementInitData>(value);
		}
	}
}
