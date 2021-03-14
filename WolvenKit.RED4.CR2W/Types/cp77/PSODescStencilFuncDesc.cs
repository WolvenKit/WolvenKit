using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescStencilFuncDesc : CVariable
	{
		private CEnum<PSODescDepthStencilModeStencilOpMode> _stencilPassOp;
		private CEnum<PSODescDepthStencilModeComparisonMode> _stencilFunc;

		[Ordinal(0)] 
		[RED("stencilPassOp")] 
		public CEnum<PSODescDepthStencilModeStencilOpMode> StencilPassOp
		{
			get
			{
				if (_stencilPassOp == null)
				{
					_stencilPassOp = (CEnum<PSODescDepthStencilModeStencilOpMode>) CR2WTypeManager.Create("PSODescDepthStencilModeStencilOpMode", "stencilPassOp", cr2w, this);
				}
				return _stencilPassOp;
			}
			set
			{
				if (_stencilPassOp == value)
				{
					return;
				}
				_stencilPassOp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stencilFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> StencilFunc
		{
			get
			{
				if (_stencilFunc == null)
				{
					_stencilFunc = (CEnum<PSODescDepthStencilModeComparisonMode>) CR2WTypeManager.Create("PSODescDepthStencilModeComparisonMode", "stencilFunc", cr2w, this);
				}
				return _stencilFunc;
			}
			set
			{
				if (_stencilFunc == value)
				{
					return;
				}
				_stencilFunc = value;
				PropertySet(this);
			}
		}

		public PSODescStencilFuncDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
