using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldClothMeshNode : worldMeshNode
	{
		private CBool _affectedByWind;
		private CEnum<physicsEClothCollisionMaskEnum> _collisionMask;

		[Ordinal(15)] 
		[RED("affectedByWind")] 
		public CBool AffectedByWind
		{
			get => GetProperty(ref _affectedByWind);
			set => SetProperty(ref _affectedByWind, value);
		}

		[Ordinal(16)] 
		[RED("collisionMask")] 
		public CEnum<physicsEClothCollisionMaskEnum> CollisionMask
		{
			get => GetProperty(ref _collisionMask);
			set => SetProperty(ref _collisionMask, value);
		}
	}
}
