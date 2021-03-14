using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Rect : vgBaseVectorGraphicShape
	{
		private Vector2 _mensions;

		[Ordinal(2)] 
		[RED("mensions")] 
		public Vector2 Mensions
		{
			get
			{
				if (_mensions == null)
				{
					_mensions = (Vector2) CR2WTypeManager.Create("Vector2", "mensions", cr2w, this);
				}
				return _mensions;
			}
			set
			{
				if (_mensions == value)
				{
					return;
				}
				_mensions = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_Rect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
