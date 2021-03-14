using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CCubeTexture : ITexture
	{
		private STextureGroupSetup _setup;
		private CUInt32 _size;
		private CHandle<IRenderResourceBlob> _renderResourceBlob;
		private rendRenderTextureResource _renderTextureResource;

		[Ordinal(1)] 
		[RED("setup")] 
		public STextureGroupSetup Setup
		{
			get
			{
				if (_setup == null)
				{
					_setup = (STextureGroupSetup) CR2WTypeManager.Create("STextureGroupSetup", "setup", cr2w, this);
				}
				return _setup;
			}
			set
			{
				if (_setup == value)
				{
					return;
				}
				_setup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CUInt32) CR2WTypeManager.Create("Uint32", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get
			{
				if (_renderResourceBlob == null)
				{
					_renderResourceBlob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "renderResourceBlob", cr2w, this);
				}
				return _renderResourceBlob;
			}
			set
			{
				if (_renderResourceBlob == value)
				{
					return;
				}
				_renderResourceBlob = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("renderTextureResource")] 
		public rendRenderTextureResource RenderTextureResource
		{
			get
			{
				if (_renderTextureResource == null)
				{
					_renderTextureResource = (rendRenderTextureResource) CR2WTypeManager.Create("rendRenderTextureResource", "renderTextureResource", cr2w, this);
				}
				return _renderTextureResource;
			}
			set
			{
				if (_renderTextureResource == value)
				{
					return;
				}
				_renderTextureResource = value;
				PropertySet(this);
			}
		}

		public CCubeTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
