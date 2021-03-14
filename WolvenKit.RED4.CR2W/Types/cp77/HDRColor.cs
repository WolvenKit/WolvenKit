using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HDRColor : CVariable
	{
		private CFloat _red;
		private CFloat _green;
		private CFloat _blue;
		private CFloat _alpha;

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
		[RED("Alpha")] 
		public CFloat Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CFloat) CR2WTypeManager.Create("Float", "Alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		public HDRColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
