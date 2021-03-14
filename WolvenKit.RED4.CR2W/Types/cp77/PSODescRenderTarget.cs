using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescRenderTarget : CVariable
	{
		private CBool _blendEnable;
		private CEnum<PSODescBlendModeWriteMask> _writeMask;
		private CEnum<PSODescBlendModeOp> _colorOp;
		private CEnum<PSODescBlendModeOp> _alphaOp;
		private CEnum<PSODescBlendModeFactor> _destFactor;
		private CEnum<PSODescBlendModeFactor> _destAlphaFactor;
		private CEnum<PSODescBlendModeFactor> _srcFactor;
		private CEnum<PSODescBlendModeFactor> _srcAlphaFactor;

		[Ordinal(0)] 
		[RED("blendEnable")] 
		public CBool BlendEnable
		{
			get
			{
				if (_blendEnable == null)
				{
					_blendEnable = (CBool) CR2WTypeManager.Create("Bool", "blendEnable", cr2w, this);
				}
				return _blendEnable;
			}
			set
			{
				if (_blendEnable == value)
				{
					return;
				}
				_blendEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("writeMask")] 
		public CEnum<PSODescBlendModeWriteMask> WriteMask
		{
			get
			{
				if (_writeMask == null)
				{
					_writeMask = (CEnum<PSODescBlendModeWriteMask>) CR2WTypeManager.Create("PSODescBlendModeWriteMask", "writeMask", cr2w, this);
				}
				return _writeMask;
			}
			set
			{
				if (_writeMask == value)
				{
					return;
				}
				_writeMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("colorOp")] 
		public CEnum<PSODescBlendModeOp> ColorOp
		{
			get
			{
				if (_colorOp == null)
				{
					_colorOp = (CEnum<PSODescBlendModeOp>) CR2WTypeManager.Create("PSODescBlendModeOp", "colorOp", cr2w, this);
				}
				return _colorOp;
			}
			set
			{
				if (_colorOp == value)
				{
					return;
				}
				_colorOp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("alphaOp")] 
		public CEnum<PSODescBlendModeOp> AlphaOp
		{
			get
			{
				if (_alphaOp == null)
				{
					_alphaOp = (CEnum<PSODescBlendModeOp>) CR2WTypeManager.Create("PSODescBlendModeOp", "alphaOp", cr2w, this);
				}
				return _alphaOp;
			}
			set
			{
				if (_alphaOp == value)
				{
					return;
				}
				_alphaOp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("destFactor")] 
		public CEnum<PSODescBlendModeFactor> DestFactor
		{
			get
			{
				if (_destFactor == null)
				{
					_destFactor = (CEnum<PSODescBlendModeFactor>) CR2WTypeManager.Create("PSODescBlendModeFactor", "destFactor", cr2w, this);
				}
				return _destFactor;
			}
			set
			{
				if (_destFactor == value)
				{
					return;
				}
				_destFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("destAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> DestAlphaFactor
		{
			get
			{
				if (_destAlphaFactor == null)
				{
					_destAlphaFactor = (CEnum<PSODescBlendModeFactor>) CR2WTypeManager.Create("PSODescBlendModeFactor", "destAlphaFactor", cr2w, this);
				}
				return _destAlphaFactor;
			}
			set
			{
				if (_destAlphaFactor == value)
				{
					return;
				}
				_destAlphaFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("srcFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcFactor
		{
			get
			{
				if (_srcFactor == null)
				{
					_srcFactor = (CEnum<PSODescBlendModeFactor>) CR2WTypeManager.Create("PSODescBlendModeFactor", "srcFactor", cr2w, this);
				}
				return _srcFactor;
			}
			set
			{
				if (_srcFactor == value)
				{
					return;
				}
				_srcFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("srcAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcAlphaFactor
		{
			get
			{
				if (_srcAlphaFactor == null)
				{
					_srcAlphaFactor = (CEnum<PSODescBlendModeFactor>) CR2WTypeManager.Create("PSODescBlendModeFactor", "srcAlphaFactor", cr2w, this);
				}
				return _srcAlphaFactor;
			}
			set
			{
				if (_srcAlphaFactor == value)
				{
					return;
				}
				_srcAlphaFactor = value;
				PropertySet(this);
			}
		}

		public PSODescRenderTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
