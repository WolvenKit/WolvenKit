using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsObjectMarkerVisibilityUpdated : redEvent
	{
		private CBool _canHaveObjectMarker;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetProperty(ref _canHaveObjectMarker);
			set => SetProperty(ref _canHaveObjectMarker, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		public gameeventsObjectMarkerVisibilityUpdated(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
