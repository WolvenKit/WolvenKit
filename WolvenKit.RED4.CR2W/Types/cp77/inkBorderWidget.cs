using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBorderWidget : inkLeafWidget
	{
		private CFloat _thickness;

		[Ordinal(20)] 
		[RED("thickness")] 
		public CFloat Thickness
		{
			get
			{
				if (_thickness == null)
				{
					_thickness = (CFloat) CR2WTypeManager.Create("Float", "thickness", cr2w, this);
				}
				return _thickness;
			}
			set
			{
				if (_thickness == value)
				{
					return;
				}
				_thickness = value;
				PropertySet(this);
			}
		}

		public inkBorderWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
