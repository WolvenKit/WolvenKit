using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingScrollBlockController : IScriptable
	{
		private inkWidgetReference _rectangle;

		[Ordinal(0)] 
		[RED("rectangle")] 
		public inkWidgetReference Rectangle
		{
			get
			{
				if (_rectangle == null)
				{
					_rectangle = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rectangle", cr2w, this);
				}
				return _rectangle;
			}
			set
			{
				if (_rectangle == value)
				{
					return;
				}
				_rectangle = value;
				PropertySet(this);
			}
		}

		public LootingScrollBlockController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
