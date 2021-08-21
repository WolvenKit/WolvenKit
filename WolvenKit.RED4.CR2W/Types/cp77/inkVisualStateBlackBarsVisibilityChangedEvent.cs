using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVisualStateBlackBarsVisibilityChangedEvent : redEvent
	{
		private CBool _blackBarsVisible;

		[Ordinal(0)] 
		[RED("blackBarsVisible")] 
		public CBool BlackBarsVisible
		{
			get => GetProperty(ref _blackBarsVisible);
			set => SetProperty(ref _blackBarsVisible, value);
		}

		public inkVisualStateBlackBarsVisibilityChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
