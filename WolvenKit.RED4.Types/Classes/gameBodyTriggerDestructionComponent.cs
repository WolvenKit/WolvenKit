using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBodyTriggerDestructionComponent : entIComponent
	{
		private CName _colliderComponentName;
		private CHandle<physicsFilterData> _filterData;
		private CFloat _impulseForce;
		private CFloat _impulseRadius;

		[Ordinal(3)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get => GetProperty(ref _colliderComponentName);
			set => SetProperty(ref _colliderComponentName, value);
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(5)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get => GetProperty(ref _impulseForce);
			set => SetProperty(ref _impulseForce, value);
		}

		[Ordinal(6)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get => GetProperty(ref _impulseRadius);
			set => SetProperty(ref _impulseRadius, value);
		}

		public gameBodyTriggerDestructionComponent()
		{
			_impulseForce = 10.000000F;
			_impulseRadius = 5.000000F;
		}
	}
}
