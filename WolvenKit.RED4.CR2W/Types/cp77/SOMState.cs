using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SOMState : CVariable
	{
		private PSODescDepthStencilModeDesc _depthStencilModeDesc;
		private PSODescRasterizerModeDesc _rasterizerModeDesc;
		private PSODescBlendModeDesc _blendModeDesc;
		private CUInt8 _stencilReadMask;
		private CUInt8 _stencilWriteMask;
		private CUInt8 _stencilRef;

		[Ordinal(0)] 
		[RED("depthStencilModeDesc")] 
		public PSODescDepthStencilModeDesc DepthStencilModeDesc
		{
			get
			{
				if (_depthStencilModeDesc == null)
				{
					_depthStencilModeDesc = (PSODescDepthStencilModeDesc) CR2WTypeManager.Create("PSODescDepthStencilModeDesc", "depthStencilModeDesc", cr2w, this);
				}
				return _depthStencilModeDesc;
			}
			set
			{
				if (_depthStencilModeDesc == value)
				{
					return;
				}
				_depthStencilModeDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rasterizerModeDesc")] 
		public PSODescRasterizerModeDesc RasterizerModeDesc
		{
			get
			{
				if (_rasterizerModeDesc == null)
				{
					_rasterizerModeDesc = (PSODescRasterizerModeDesc) CR2WTypeManager.Create("PSODescRasterizerModeDesc", "rasterizerModeDesc", cr2w, this);
				}
				return _rasterizerModeDesc;
			}
			set
			{
				if (_rasterizerModeDesc == value)
				{
					return;
				}
				_rasterizerModeDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendModeDesc")] 
		public PSODescBlendModeDesc BlendModeDesc
		{
			get
			{
				if (_blendModeDesc == null)
				{
					_blendModeDesc = (PSODescBlendModeDesc) CR2WTypeManager.Create("PSODescBlendModeDesc", "blendModeDesc", cr2w, this);
				}
				return _blendModeDesc;
			}
			set
			{
				if (_blendModeDesc == value)
				{
					return;
				}
				_blendModeDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stencilReadMask")] 
		public CUInt8 StencilReadMask
		{
			get
			{
				if (_stencilReadMask == null)
				{
					_stencilReadMask = (CUInt8) CR2WTypeManager.Create("Uint8", "stencilReadMask", cr2w, this);
				}
				return _stencilReadMask;
			}
			set
			{
				if (_stencilReadMask == value)
				{
					return;
				}
				_stencilReadMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stencilWriteMask")] 
		public CUInt8 StencilWriteMask
		{
			get
			{
				if (_stencilWriteMask == null)
				{
					_stencilWriteMask = (CUInt8) CR2WTypeManager.Create("Uint8", "stencilWriteMask", cr2w, this);
				}
				return _stencilWriteMask;
			}
			set
			{
				if (_stencilWriteMask == value)
				{
					return;
				}
				_stencilWriteMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stencilRef")] 
		public CUInt8 StencilRef
		{
			get
			{
				if (_stencilRef == null)
				{
					_stencilRef = (CUInt8) CR2WTypeManager.Create("Uint8", "stencilRef", cr2w, this);
				}
				return _stencilRef;
			}
			set
			{
				if (_stencilRef == value)
				{
					return;
				}
				_stencilRef = value;
				PropertySet(this);
			}
		}

		public SOMState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
