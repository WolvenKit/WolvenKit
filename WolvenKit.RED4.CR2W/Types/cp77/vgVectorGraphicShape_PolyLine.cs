using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
	{
		private CArray<Vector2> _ints;
		private CFloat _roke;

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

		[Ordinal(3)] 
		[RED("roke")] 
		public CFloat Roke
		{
			get
			{
				if (_roke == null)
				{
					_roke = (CFloat) CR2WTypeManager.Create("Float", "roke", cr2w, this);
				}
				return _roke;
			}
			set
			{
				if (_roke == value)
				{
					return;
				}
				_roke = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_PolyLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
