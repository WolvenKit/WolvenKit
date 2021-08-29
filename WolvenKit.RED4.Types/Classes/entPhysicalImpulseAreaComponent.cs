using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPhysicalImpulseAreaComponent : entPhysicalTriggerComponent
	{
		private Vector3 _impulse;
		private CFloat _impulseRadius;

		[Ordinal(9)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}

		[Ordinal(10)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetProperty(ref _impulseRadius);
			set => SetProperty(ref _impulseRadius, value);
		}
	}
}
