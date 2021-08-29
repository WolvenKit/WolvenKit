using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorLineOfSightClearConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CName> _collisionFilters;
		private Vector3 _offset;
		private CHandle<AIArgumentMapping> _target;

		[Ordinal(1)] 
		[RED("collisionFilters")] 
		public CArray<CName> CollisionFilters
		{
			get => GetProperty(ref _collisionFilters);
			set => SetProperty(ref _collisionFilters, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
