using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMeshBlob : IRenderResourceBlob
	{
		private rendRenderMeshBlobHeader _header;
		private DataBuffer _renderBuffer;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMeshBlobHeader Header
		{
			get
			{
				if (_header == null)
				{
					_header = (rendRenderMeshBlobHeader) CR2WTypeManager.Create("rendRenderMeshBlobHeader", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("renderBuffer")] 
		public DataBuffer RenderBuffer
		{
			get
			{
				if (_renderBuffer == null)
				{
					_renderBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "renderBuffer", cr2w, this);
				}
				return _renderBuffer;
			}
			set
			{
				if (_renderBuffer == value)
				{
					return;
				}
				_renderBuffer = value;
				PropertySet(this);
			}
		}

		public rendRenderMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
