using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldPhysicalImpulseAreaNode()
		{
			Impulse = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
