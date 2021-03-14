using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChromaticAberrationAreaSettings : IAreaSettings
	{
		private CBool _chromaticAberrationEnabled;
		private CFloat _chromaticAberrationMargin;
		private CFloat _chromaticAberrationOffset;
		private CFloat _chromaticAberrationExp;
		private CFloat _subpixelDispersal;

		[Ordinal(2)] 
		[RED("chromaticAberrationEnabled")] 
		public CBool ChromaticAberrationEnabled
		{
			get
			{
				if (_chromaticAberrationEnabled == null)
				{
					_chromaticAberrationEnabled = (CBool) CR2WTypeManager.Create("Bool", "chromaticAberrationEnabled", cr2w, this);
				}
				return _chromaticAberrationEnabled;
			}
			set
			{
				if (_chromaticAberrationEnabled == value)
				{
					return;
				}
				_chromaticAberrationEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chromaticAberrationMargin")] 
		public CFloat ChromaticAberrationMargin
		{
			get
			{
				if (_chromaticAberrationMargin == null)
				{
					_chromaticAberrationMargin = (CFloat) CR2WTypeManager.Create("Float", "chromaticAberrationMargin", cr2w, this);
				}
				return _chromaticAberrationMargin;
			}
			set
			{
				if (_chromaticAberrationMargin == value)
				{
					return;
				}
				_chromaticAberrationMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationOffset")] 
		public CFloat ChromaticAberrationOffset
		{
			get
			{
				if (_chromaticAberrationOffset == null)
				{
					_chromaticAberrationOffset = (CFloat) CR2WTypeManager.Create("Float", "chromaticAberrationOffset", cr2w, this);
				}
				return _chromaticAberrationOffset;
			}
			set
			{
				if (_chromaticAberrationOffset == value)
				{
					return;
				}
				_chromaticAberrationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public CFloat ChromaticAberrationExp
		{
			get
			{
				if (_chromaticAberrationExp == null)
				{
					_chromaticAberrationExp = (CFloat) CR2WTypeManager.Create("Float", "chromaticAberrationExp", cr2w, this);
				}
				return _chromaticAberrationExp;
			}
			set
			{
				if (_chromaticAberrationExp == value)
				{
					return;
				}
				_chromaticAberrationExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("subpixelDispersal")] 
		public CFloat SubpixelDispersal
		{
			get
			{
				if (_subpixelDispersal == null)
				{
					_subpixelDispersal = (CFloat) CR2WTypeManager.Create("Float", "subpixelDispersal", cr2w, this);
				}
				return _subpixelDispersal;
			}
			set
			{
				if (_subpixelDispersal == value)
				{
					return;
				}
				_subpixelDispersal = value;
				PropertySet(this);
			}
		}

		public ChromaticAberrationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
