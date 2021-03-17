using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuButtonItem : AnimatedListItemController
	{
		private inkTextWidgetReference _fluff;
		private CHandle<inkanimProxy> _animLoop;

		[Ordinal(30)] 
		[RED("Fluff")] 
		public inkTextWidgetReference Fluff
		{
			get => GetProperty(ref _fluff);
			set => SetProperty(ref _fluff, value);
		}

		[Ordinal(31)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetProperty(ref _animLoop);
			set => SetProperty(ref _animLoop, value);
		}

		public PauseMenuButtonItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
