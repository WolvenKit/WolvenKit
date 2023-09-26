using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldClothMeshNode : worldMeshNode
	{
		[Ordinal(18)] 
		[RED("affectedByWind")] 
		public CBool AffectedByWind
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("collisionMask")] 
		public CBitField<physicsEClothCollisionMaskEnum> CollisionMask
		{
			get => GetPropertyValue<CBitField<physicsEClothCollisionMaskEnum>>();
			set => SetPropertyValue<CBitField<physicsEClothCollisionMaskEnum>>(value);
		}

		public worldClothMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
