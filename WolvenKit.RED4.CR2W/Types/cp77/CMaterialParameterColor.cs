using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterColor : CMaterialParameter
	{
		private CColor _color;

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
