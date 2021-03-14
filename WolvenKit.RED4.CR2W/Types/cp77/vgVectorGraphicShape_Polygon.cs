using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Polygon : vgBaseVectorGraphicShape
	{
		private CArray<Vector2> _ints;

		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get
			{
				if (_ints == null)
				{
					_ints = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "ints", cr2w, this);
				}
				return _ints;
			}
			set
			{
				if (_ints == value)
				{
					return;
				}
				_ints = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_Polygon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
