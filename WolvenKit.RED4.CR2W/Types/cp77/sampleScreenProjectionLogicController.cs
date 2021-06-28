using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleScreenProjectionLogicController : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _widgetPos;
		private wCHandle<inkTextWidget> _worldPos;
		private CHandle<inkScreenProjection> _projection;

		[Ordinal(1)] 
		[RED("widgetPos")] 
		public wCHandle<inkTextWidget> WidgetPos
		{
			get => GetProperty(ref _widgetPos);
			set => SetProperty(ref _widgetPos, value);
		}

		[Ordinal(2)] 
		[RED("worldPos")] 
		public wCHandle<inkTextWidget> WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}

		[Ordinal(3)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		public sampleScreenProjectionLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
