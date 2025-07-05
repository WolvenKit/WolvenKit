using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameIMovingPlatformMovementInitData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("initType")] 
		public CEnum<gameMovingPlatformMovementInitializationType> InitType
		{
			get => GetPropertyValue<CEnum<gameMovingPlatformMovementInitializationType>>();
			set => SetPropertyValue<CEnum<gameMovingPlatformMovementInitializationType>>(value);
		}

		[Ordinal(1)] 
		[RED("initValue")] 
		public CFloat InitValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameIMovingPlatformMovementInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
