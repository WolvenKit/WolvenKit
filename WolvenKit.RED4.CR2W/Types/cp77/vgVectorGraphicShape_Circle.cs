using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		private CFloat _dius;

		[Ordinal(2)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get
			{
				if (_dius == null)
				{
					_dius = (CFloat) CR2WTypeManager.Create("Float", "dius", cr2w, this);
				}
				return _dius;
			}
			set
			{
				if (_dius == value)
				{
					return;
				}
				_dius = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_Circle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
