using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescDepthStencilModeDesc : CVariable
	{
		private CBool _depthTestEnable;
		private CBool _depthWriteEnable;
		private CEnum<PSODescDepthStencilModeComparisonMode> _depthFunc;
		private CBool _stencilEnable;
		private CBool _stencilReadMask;
		private CBool _stencilWriteMask;
		private PSODescStencilFuncDesc _frontFace;

		[Ordinal(0)] 
		[RED("depthTestEnable")] 
		public CBool DepthTestEnable
		{
			get
			{
				if (_depthTestEnable == null)
				{
					_depthTestEnable = (CBool) CR2WTypeManager.Create("Bool", "depthTestEnable", cr2w, this);
				}
				return _depthTestEnable;
			}
			set
			{
				if (_depthTestEnable == value)
				{
					return;
				}
				_depthTestEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("depthWriteEnable")] 
		public CBool DepthWriteEnable
		{
			get
			{
				if (_depthWriteEnable == null)
				{
					_depthWriteEnable = (CBool) CR2WTypeManager.Create("Bool", "depthWriteEnable", cr2w, this);
				}
				return _depthWriteEnable;
			}
			set
			{
				if (_depthWriteEnable == value)
				{
					return;
				}
				_depthWriteEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("depthFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> DepthFunc
		{
			get
			{
				if (_depthFunc == null)
				{
					_depthFunc = (CEnum<PSODescDepthStencilModeComparisonMode>) CR2WTypeManager.Create("PSODescDepthStencilModeComparisonMode", "depthFunc", cr2w, this);
				}
				return _depthFunc;
			}
			set
			{
				if (_depthFunc == value)
				{
					return;
				}
				_depthFunc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stencilEnable")] 
		public CBool StencilEnable
		{
			get
			{
				if (_stencilEnable == null)
				{
					_stencilEnable = (CBool) CR2WTypeManager.Create("Bool", "stencilEnable", cr2w, this);
				}
				return _stencilEnable;
			}
			set
			{
				if (_stencilEnable == value)
				{
					return;
				}
				_stencilEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stencilReadMask")] 
		public CBool StencilReadMask
		{
			get
			{
				if (_stencilReadMask == null)
				{
					_stencilReadMask = (CBool) CR2WTypeManager.Create("Bool", "stencilReadMask", cr2w, this);
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

		[Ordinal(5)] 
		[RED("stencilWriteMask")] 
		public CBool StencilWriteMask
		{
			get
			{
				if (_stencilWriteMask == null)
				{
					_stencilWriteMask = (CBool) CR2WTypeManager.Create("Bool", "stencilWriteMask", cr2w, this);
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

		[Ordinal(6)] 
		[RED("frontFace")] 
		public PSODescStencilFuncDesc FrontFace
		{
			get
			{
				if (_frontFace == null)
				{
					_frontFace = (PSODescStencilFuncDesc) CR2WTypeManager.Create("PSODescStencilFuncDesc", "frontFace", cr2w, this);
				}
				return _frontFace;
			}
			set
			{
				if (_frontFace == value)
				{
					return;
				}
				_frontFace = value;
				PropertySet(this);
			}
		}

		public PSODescDepthStencilModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
