using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetUICameraZoomEvent : redEvent
	{
		private CBool _hasUICameraZoom;

		[Ordinal(0)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get
			{
				if (_hasUICameraZoom == null)
				{
					_hasUICameraZoom = (CBool) CR2WTypeManager.Create("Bool", "hasUICameraZoom", cr2w, this);
				}
				return _hasUICameraZoom;
			}
			set
			{
				if (_hasUICameraZoom == value)
				{
					return;
				}
				_hasUICameraZoom = value;
				PropertySet(this);
			}
		}

		public SetUICameraZoomEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
