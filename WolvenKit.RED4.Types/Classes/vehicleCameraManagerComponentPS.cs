using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCameraManagerComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<vehicleCameraPerspective> Perspective
		{
			get => GetPropertyValue<CEnum<vehicleCameraPerspective>>();
			set => SetPropertyValue<CEnum<vehicleCameraPerspective>>(value);
		}

		public vehicleCameraManagerComponentPS()
		{
			Perspective = Enums.vehicleCameraPerspective.TPPFar;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
