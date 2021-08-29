using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDbgOverlapBox : RedBaseClass
	{
		private Box _box;
		private Transform _transform;
		private CUInt32 _level;
		private CBool _isHit;

		[Ordinal(0)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(3)] 
		[RED("isHit")] 
		public CBool IsHit
		{
			get => GetProperty(ref _isHit);
			set => SetProperty(ref _isHit, value);
		}
	}
}
