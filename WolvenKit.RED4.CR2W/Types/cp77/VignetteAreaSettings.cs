using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VignetteAreaSettings : IAreaSettings
	{
		private CBool _vignetteEnabled;
		private CFloat _vignetteRadius;
		private CFloat _vignetteExp;
		private CColor _vignetteColor;

		[Ordinal(2)] 
		[RED("vignetteEnabled")] 
		public CBool VignetteEnabled
		{
			get
			{
				if (_vignetteEnabled == null)
				{
					_vignetteEnabled = (CBool) CR2WTypeManager.Create("Bool", "vignetteEnabled", cr2w, this);
				}
				return _vignetteEnabled;
			}
			set
			{
				if (_vignetteEnabled == value)
				{
					return;
				}
				_vignetteEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vignetteRadius")] 
		public CFloat VignetteRadius
		{
			get
			{
				if (_vignetteRadius == null)
				{
					_vignetteRadius = (CFloat) CR2WTypeManager.Create("Float", "vignetteRadius", cr2w, this);
				}
				return _vignetteRadius;
			}
			set
			{
				if (_vignetteRadius == value)
				{
					return;
				}
				_vignetteRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vignetteExp")] 
		public CFloat VignetteExp
		{
			get
			{
				if (_vignetteExp == null)
				{
					_vignetteExp = (CFloat) CR2WTypeManager.Create("Float", "vignetteExp", cr2w, this);
				}
				return _vignetteExp;
			}
			set
			{
				if (_vignetteExp == value)
				{
					return;
				}
				_vignetteExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vignetteColor")] 
		public CColor VignetteColor
		{
			get
			{
				if (_vignetteColor == null)
				{
					_vignetteColor = (CColor) CR2WTypeManager.Create("Color", "vignetteColor", cr2w, this);
				}
				return _vignetteColor;
			}
			set
			{
				if (_vignetteColor == value)
				{
					return;
				}
				_vignetteColor = value;
				PropertySet(this);
			}
		}

		public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
