using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendVertexBufferChunk : CVariable
	{
		private GpuWrapApiVertexLayoutDesc _vertexLayout;
		private CStatic<CUInt32> _byteOffsets;

		[Ordinal(0)] 
		[RED("vertexLayout")] 
		public GpuWrapApiVertexLayoutDesc VertexLayout
		{
			get
			{
				if (_vertexLayout == null)
				{
					_vertexLayout = (GpuWrapApiVertexLayoutDesc) CR2WTypeManager.Create("GpuWrapApiVertexLayoutDesc", "vertexLayout", cr2w, this);
				}
				return _vertexLayout;
			}
			set
			{
				if (_vertexLayout == value)
				{
					return;
				}
				_vertexLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("byteOffsets", 5)] 
		public CStatic<CUInt32> ByteOffsets
		{
			get
			{
				if (_byteOffsets == null)
				{
					_byteOffsets = (CStatic<CUInt32>) CR2WTypeManager.Create("static:5,Uint32", "byteOffsets", cr2w, this);
				}
				return _byteOffsets;
			}
			set
			{
				if (_byteOffsets == value)
				{
					return;
				}
				_byteOffsets = value;
				PropertySet(this);
			}
		}

		public rendVertexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
