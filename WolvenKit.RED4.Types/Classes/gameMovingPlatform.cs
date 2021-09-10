using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatform : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("loopType")] 
		public CEnum<gameMovingPlatformLoopType> LoopType
		{
			get => GetPropertyValue<CEnum<gameMovingPlatformLoopType>>();
			set => SetPropertyValue<CEnum<gameMovingPlatformLoopType>>(value);
		}

		public gameMovingPlatform()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
		}
	}
}
