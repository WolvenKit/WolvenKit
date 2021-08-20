using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Jukebox : InteractiveDevice
	{
		private wCHandle<IWorldWidgetComponent> _uiComponentBig;

		[Ordinal(97)] 
		[RED("uiComponentBig")] 
		public wCHandle<IWorldWidgetComponent> UiComponentBig
		{
			get => GetProperty(ref _uiComponentBig);
			set => SetProperty(ref _uiComponentBig, value);
		}

		public Jukebox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
