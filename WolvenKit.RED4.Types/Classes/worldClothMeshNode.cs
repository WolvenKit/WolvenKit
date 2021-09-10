using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldClothMeshNode : worldMeshNode
	{
		[Ordinal(15)] 
		[RED("affectedByWind")] 
		public CBool AffectedByWind
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("collisionMask")] 
		public CBitField<physicsEClothCollisionMaskEnum> CollisionMask
		{
			get => GetPropertyValue<CBitField<physicsEClothCollisionMaskEnum>>();
			set => SetPropertyValue<CBitField<physicsEClothCollisionMaskEnum>>(value);
		}
	}
}
