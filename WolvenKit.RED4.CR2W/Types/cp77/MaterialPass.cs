using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialPass : CVariable
	{
		private CName _stagePassNameRegular;
		private CName _stagePassNameDiscarded;
		private PSODescDepthStencilModeDesc _depthStencilMode;
		private PSODescRasterizerModeDesc _rasterizerMode;
		private PSODescBlendModeDesc _blendMode;
		private CUInt8 _stencilReadMask;
		private CUInt8 _stencilWriteMask;
		private CUInt8 _stencilRef;
		private CUInt8 _orderIndex;
		private CBool _enablePixelShader;

		[Ordinal(0)] 
		[RED("stagePassNameRegular")] 
		public CName StagePassNameRegular
		{
			get
			{
				if (_stagePassNameRegular == null)
				{
					_stagePassNameRegular = (CName) CR2WTypeManager.Create("CName", "stagePassNameRegular", cr2w, this);
				}
				return _stagePassNameRegular;
			}
			set
			{
				if (_stagePassNameRegular == value)
				{
					return;
				}
				_stagePassNameRegular = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stagePassNameDiscarded")] 
		public CName StagePassNameDiscarded
		{
			get
			{
				if (_stagePassNameDiscarded == null)
				{
					_stagePassNameDiscarded = (CName) CR2WTypeManager.Create("CName", "stagePassNameDiscarded", cr2w, this);
				}
				return _stagePassNameDiscarded;
			}
			set
			{
				if (_stagePassNameDiscarded == value)
				{
					return;
				}
				_stagePassNameDiscarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("depthStencilMode")] 
		public PSODescDepthStencilModeDesc DepthStencilMode
		{
			get
			{
				if (_depthStencilMode == null)
				{
					_depthStencilMode = (PSODescDepthStencilModeDesc) CR2WTypeManager.Create("PSODescDepthStencilModeDesc", "depthStencilMode", cr2w, this);
				}
				return _depthStencilMode;
			}
			set
			{
				if (_depthStencilMode == value)
				{
					return;
				}
				_depthStencilMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rasterizerMode")] 
		public PSODescRasterizerModeDesc RasterizerMode
		{
			get
			{
				if (_rasterizerMode == null)
				{
					_rasterizerMode = (PSODescRasterizerModeDesc) CR2WTypeManager.Create("PSODescRasterizerModeDesc", "rasterizerMode", cr2w, this);
				}
				return _rasterizerMode;
			}
			set
			{
				if (_rasterizerMode == value)
				{
					return;
				}
				_rasterizerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendMode")] 
		public PSODescBlendModeDesc BlendMode
		{
			get
			{
				if (_blendMode == null)
				{
					_blendMode = (PSODescBlendModeDesc) CR2WTypeManager.Create("PSODescBlendModeDesc", "blendMode", cr2w, this);
				}
				return _blendMode;
			}
			set
			{
				if (_blendMode == value)
				{
					return;
				}
				_blendMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("orderIndex")] 
		public CUInt8 OrderIndex
		{
			get
			{
				if (_orderIndex == null)
				{
					_orderIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "orderIndex", cr2w, this);
				}
				return _orderIndex;
			}
			set
			{
				if (_orderIndex == value)
				{
					return;
				}
				_orderIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enablePixelShader")] 
		public CBool EnablePixelShader
		{
			get
			{
				if (_enablePixelShader == null)
				{
					_enablePixelShader = (CBool) CR2WTypeManager.Create("Bool", "enablePixelShader", cr2w, this);
				}
				return _enablePixelShader;
			}
			set
			{
				if (_enablePixelShader == value)
				{
					return;
				}
				_enablePixelShader = value;
				PropertySet(this);
			}
		}

		public MaterialPass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
