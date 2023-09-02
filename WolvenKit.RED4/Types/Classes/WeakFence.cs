using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakFence : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(95)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(96)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(97)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		[Ordinal(98)] 
		[RED("currentWorkspotSuffix")] 
		public CName CurrentWorkspotSuffix
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(99)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("physicalMesh")] 
		public CHandle<entIPlacedComponent> PhysicalMesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public WeakFence()
		{
			ImpulseVector = new Vector4();
			SideTriggerNames = new();
			TriggerComponents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
