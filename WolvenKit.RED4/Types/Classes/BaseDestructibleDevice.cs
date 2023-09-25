using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseDestructibleDevice : Device
	{
		[Ordinal(88)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(89)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(90)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		public BaseDestructibleDevice()
		{
			ControllerTypeName = "BaseDestructibleController";
			MinTime = 5.000000F;
			MaxTime = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
