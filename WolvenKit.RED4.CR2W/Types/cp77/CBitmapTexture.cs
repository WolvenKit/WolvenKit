using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CBitmapTexture : ITexture
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _depth;
		private STextureGroupSetup _setup;
		private Vector3 _histBiasMulCoef;
		private Vector3 _histBiasAddCoef;
		private CHandle<IRenderResourceBlob> _renderResourceBlob;
		private rendRenderTextureResource _renderTextureResource;

		[Ordinal(1)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CUInt32) CR2WTypeManager.Create("Uint32", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CUInt32) CR2WTypeManager.Create("Uint32", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CUInt32) CR2WTypeManager.Create("Uint32", "depth", cr2w, this);
				}
				return _depth;
			}
			set
			{
				if (_depth == value)
				{
					return;
				}
				_depth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("histBiasMulCoef")] 
		public Vector3 HistBiasMulCoef
		{
			get
			{
				if (_histBiasMulCoef == null)
				{
					_histBiasMulCoef = (Vector3) CR2WTypeManager.Create("Vector3", "histBiasMulCoef", cr2w, this);
				}
				return _histBiasMulCoef;
			}
			set
			{
				if (_histBiasMulCoef == value)
				{
					return;
				}
				_histBiasMulCoef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("histBiasAddCoef")] 
		public Vector3 HistBiasAddCoef
		{
			get
			{
				if (_histBiasAddCoef == null)
				{
					_histBiasAddCoef = (Vector3) CR2WTypeManager.Create("Vector3", "histBiasAddCoef", cr2w, this);
				}
				return _histBiasAddCoef;
			}
			set
			{
				if (_histBiasAddCoef == value)
				{
					return;
				}
				_histBiasAddCoef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
