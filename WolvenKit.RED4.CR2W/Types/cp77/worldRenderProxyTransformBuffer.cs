using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRenderProxyTransformBuffer : CVariable
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

		public worldRenderProxyTransformBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
