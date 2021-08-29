using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTransformBuffer : RedBaseClass
	{
		private CHandle<worldSharedDataBuffer> _sharedDataBuffer;
		private CUInt32 _startIndex;
		private CUInt32 _numElements;

		[Ordinal(0)] 
		[RED("sharedDataBuffer")] 
		public CHandle<worldSharedDataBuffer> SharedDataBuffer
		{
			get => GetProperty(ref _sharedDataBuffer);
			set => SetProperty(ref _sharedDataBuffer, value);
		}

		[Ordinal(1)] 
		[RED("startIndex")] 
		public CUInt32 StartIndex
		{
			get => GetProperty(ref _startIndex);
			set => SetProperty(ref _startIndex, value);
		}

		[Ordinal(2)] 
		[RED("numElements")] 
		public CUInt32 NumElements
		{
			get => GetProperty(ref _numElements);
			set => SetProperty(ref _numElements, value);
		}
	}
}
