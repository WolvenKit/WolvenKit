using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _plateHolder;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<gameIBlackboard> _narrativePlateBlackboard;
		private CUInt32 _narrativePlateBlackboardText;
		private wCHandle<NarrativePlateLogicController> _logicController;

		[Ordinal(9)] 
		[RED("plateHolder")] 
		public inkWidgetReference PlateHolder
		{
			get => GetProperty(ref _plateHolder);
			set => SetProperty(ref _plateHolder, value);
		}

		[Ordinal(10)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(11)] 
		[RED("narrativePlateBlackboard")] 
		public CHandle<gameIBlackboard> NarrativePlateBlackboard
		{
			get => GetProperty(ref _narrativePlateBlackboard);
			set => SetProperty(ref _narrativePlateBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("narrativePlateBlackboardText")] 
		public CUInt32 NarrativePlateBlackboardText
		{
			get => GetProperty(ref _narrativePlateBlackboardText);
			set => SetProperty(ref _narrativePlateBlackboardText, value);
		}

		[Ordinal(13)] 
		[RED("logicController")] 
		public wCHandle<NarrativePlateLogicController> LogicController
		{
			get => GetProperty(ref _logicController);
			set => SetProperty(ref _logicController, value);
		}

		public NarrativePlateGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
