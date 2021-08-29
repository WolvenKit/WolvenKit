using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoleVectorDetails : RedBaseClass
	{
		private animTransformIndex _targetBone;
		private Vector3 _positionOffset;

		[Ordinal(0)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetProperty(ref _targetBone);
			set => SetProperty(ref _targetBone, value);
		}

		[Ordinal(1)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}
	}
}
