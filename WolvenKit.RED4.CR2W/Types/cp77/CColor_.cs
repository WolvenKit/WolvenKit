using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CColor_ : CVariable
	{
		private CUInt8 _red;
		private CUInt8 _green;
		private CUInt8 _blue;
		private CUInt8 _alpha;

		[Ordinal(0)] 
		[RED("Red")] 
		public CUInt8 Red
		{
			get
			{
				if (_red == null)
				{
					_red = (CUInt8) CR2WTypeManager.Create("Uint8", "Red", cr2w, this);
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
		public CUInt8 Green
		{
			get
			{
				if (_green == null)
				{
					_green = (CUInt8) CR2WTypeManager.Create("Uint8", "Green", cr2w, this);
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
		public CUInt8 Blue
		{
			get
			{
				if (_blue == null)
				{
					_blue = (CUInt8) CR2WTypeManager.Create("Uint8", "Blue", cr2w, this);
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
		public CUInt8 Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CUInt8) CR2WTypeManager.Create("Uint8", "Alpha", cr2w, this);
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

		public CColor_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
