using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPositionSpec : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		public AIPositionSpec()
		{
			WorldPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
