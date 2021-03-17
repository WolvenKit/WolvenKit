using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldClothMeshNode : worldMeshNode
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

		public worldClothMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
