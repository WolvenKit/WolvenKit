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
			get
			{
				if (_sharedDataBuffer == null)
				{
					_sharedDataBuffer = (CHandle<worldSharedDataBuffer>) CR2WTypeManager.Create("handle:worldSharedDataBuffer", "sharedDataBuffer", cr2w, this);
				}
				return _sharedDataBuffer;
			}
			set
			{
				if (_sharedDataBuffer == value)
				{
					return;
				}
				_sharedDataBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startIndex")] 
		public CUInt32 StartIndex
		{
			get
			{
				if (_startIndex == null)
				{
					_startIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "startIndex", cr2w, this);
				}
				return _startIndex;
			}
			set
			{
				if (_startIndex == value)
				{
					return;
				}
				_startIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numElements")] 
		public CUInt32 NumElements
		{
			get
			{
				if (_numElements == null)
				{
					_numElements = (CUInt32) CR2WTypeManager.Create("Uint32", "numElements", cr2w, this);
				}
				return _numElements;
			}
			set
			{
				if (_numElements == value)
				{
					return;
				}
				_numElements = value;
				PropertySet(this);
			}
		}

		public worldRenderProxyTransformBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
