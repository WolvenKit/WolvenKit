using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreenInkGameController : LcdScreenInkGameController
	{
		private wCHandle<inkImageWidget> _backgroundFrameWidget;

		[Ordinal(25)] 
		[RED("backgroundFrameWidget")] 
		public wCHandle<inkImageWidget> BackgroundFrameWidget
		{
			get => GetProperty(ref _backgroundFrameWidget);
			set => SetProperty(ref _backgroundFrameWidget, value);
		}

		public ApartmentScreenInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
