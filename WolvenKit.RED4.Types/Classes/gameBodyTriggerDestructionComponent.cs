using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBodyTriggerDestructionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(5)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBodyTriggerDestructionComponent()
		{
			Name = "Component";
			ImpulseForce = 10.000000F;
			ImpulseRadius = 5.000000F;
		}
	}
}
