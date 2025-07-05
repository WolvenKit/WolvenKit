using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSApplyRotationIKSolverData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animSApplyRotationIKSolverData()
		{
			Bone = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
