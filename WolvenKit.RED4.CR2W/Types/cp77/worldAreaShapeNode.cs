using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAreaShapeNode : worldNode
	{
		private CColor _color;
		private CHandle<AreaShapeOutline> _outline;

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get
			{
				if (_outline == null)
				{
					_outline = (CHandle<AreaShapeOutline>) CR2WTypeManager.Create("handle:AreaShapeOutline", "outline", cr2w, this);
				}
				return _outline;
			}
			set
			{
				if (_outline == value)
				{
					return;
				}
				_outline = value;
				PropertySet(this);
			}
		}

		public worldAreaShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
