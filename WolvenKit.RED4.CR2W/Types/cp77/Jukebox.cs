using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Jukebox : InteractiveDevice
	{
		private wCHandle<IWorldWidgetComponent> _uiComponentBig;

		[Ordinal(93)] 
		[RED("uiComponentBig")] 
		public wCHandle<IWorldWidgetComponent> UiComponentBig
		{
			get
			{
				if (_uiComponentBig == null)
				{
					_uiComponentBig = (wCHandle<IWorldWidgetComponent>) CR2WTypeManager.Create("whandle:IWorldWidgetComponent", "uiComponentBig", cr2w, this);
				}
				return _uiComponentBig;
			}
			set
			{
				if (_uiComponentBig == value)
				{
					return;
				}
				_uiComponentBig = value;
				PropertySet(this);
			}
		}

		public Jukebox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
