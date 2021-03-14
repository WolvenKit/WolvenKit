using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescBlendModeDesc : CVariable
	{
		private CUInt8 _numTargets;
		private CBool _independent;
		private CBool _alphaToCoverage;
		private CArrayFixedSize<PSODescRenderTarget> _renderTarget;

		[Ordinal(0)] 
		[RED("numTargets")] 
		public CUInt8 NumTargets
		{
			get
			{
				if (_numTargets == null)
				{
					_numTargets = (CUInt8) CR2WTypeManager.Create("Uint8", "numTargets", cr2w, this);
				}
				return _numTargets;
			}
			set
			{
				if (_numTargets == value)
				{
					return;
				}
				_numTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("independent")] 
		public CBool Independent
		{
			get
			{
				if (_independent == null)
				{
					_independent = (CBool) CR2WTypeManager.Create("Bool", "independent", cr2w, this);
				}
				return _independent;
			}
			set
			{
				if (_independent == value)
				{
					return;
				}
				_independent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("alphaToCoverage")] 
		public CBool AlphaToCoverage
		{
			get
			{
				if (_alphaToCoverage == null)
				{
					_alphaToCoverage = (CBool) CR2WTypeManager.Create("Bool", "alphaToCoverage", cr2w, this);
				}
				return _alphaToCoverage;
			}
			set
			{
				if (_alphaToCoverage == value)
				{
					return;
				}
				_alphaToCoverage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("renderTarget", 8)] 
		public CArrayFixedSize<PSODescRenderTarget> RenderTarget
		{
			get
			{
				if (_renderTarget == null)
				{
					_renderTarget = (CArrayFixedSize<PSODescRenderTarget>) CR2WTypeManager.Create("[8]PSODescRenderTarget", "renderTarget", cr2w, this);
				}
				return _renderTarget;
			}
			set
			{
				if (_renderTarget == value)
				{
					return;
				}
				_renderTarget = value;
				PropertySet(this);
			}
		}

		public PSODescBlendModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
