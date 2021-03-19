using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTriggerDestructionComponent : entIComponent
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

		public gameBodyTriggerDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
