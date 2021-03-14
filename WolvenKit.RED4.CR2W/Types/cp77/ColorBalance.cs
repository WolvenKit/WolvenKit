using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorBalance : CVariable
	{
		private CFloat _red;
		private CFloat _green;
		private CFloat _blue;
		private CFloat _luminance;

		[Ordinal(0)] 
		[RED("Red")] 
		public CFloat Red
		{
			get
			{
				if (_red == null)
				{
					_red = (CFloat) CR2WTypeManager.Create("Float", "Red", cr2w, this);
				}
				return _red;
			}
			set
			{
				if (_red == value)
				{
					return;
				}
				_red = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CFloat Green
		{
			get
			{
				if (_green == null)
				{
					_green = (CFloat) CR2WTypeManager.Create("Float", "Green", cr2w, this);
				}
				return _green;
			}
			set
			{
				if (_green == value)
				{
					return;
				}
				_green = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CFloat Blue
		{
			get
			{
				if (_blue == null)
				{
					_blue = (CFloat) CR2WTypeManager.Create("Float", "Blue", cr2w, this);
				}
				return _blue;
			}
			set
			{
				if (_blue == value)
				{
					return;
				}
				_blue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Luminance")] 
		public CFloat Luminance
		{
			get
			{
				if (_luminance == null)
				{
					_luminance = (CFloat) CR2WTypeManager.Create("Float", "Luminance", cr2w, this);
				}
				return _luminance;
			}
			set
			{
				if (_luminance == value)
				{
					return;
				}
				_luminance = value;
				PropertySet(this);
			}
		}

		public ColorBalance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
