using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficGlobalPathPosition : ISerializable
	{
		private Vector3 _worldPosition;
		private CUInt32 _pathIdx;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("pathIdx")] 
		public CUInt32 PathIdx
		{
			get => GetProperty(ref _pathIdx);
			set => SetProperty(ref _pathIdx, value);
		}
	}
}
