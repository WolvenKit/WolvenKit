using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSetStyleEvent : inkanimEvent
	{
		private raRef<inkStyleResource> _style;

		[Ordinal(1)] 
		[RED("style")] 
		public raRef<inkStyleResource> Style
		{
			get
			{
				if (_style == null)
				{
					_style = (raRef<inkStyleResource>) CR2WTypeManager.Create("raRef:inkStyleResource", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		public inkanimSetStyleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
