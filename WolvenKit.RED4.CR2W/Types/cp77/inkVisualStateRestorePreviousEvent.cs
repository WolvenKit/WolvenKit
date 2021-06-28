using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVisualStateRestorePreviousEvent : redEvent
	{
		private CName _visualState;

		[Ordinal(0)] 
		[RED("visualState")] 
		public CName VisualState
		{
			get => GetProperty(ref _visualState);
			set => SetProperty(ref _visualState, value);
		}

		public inkVisualStateRestorePreviousEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
