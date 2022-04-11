using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoleVectorDetails : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public animPoleVectorDetails()
		{
			TargetBone = new();
			PositionOffset = new();
		}
	}
}
