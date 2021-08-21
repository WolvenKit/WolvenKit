using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class instrumentPanelLogicController : IVehicleModuleController
	{
		private inkImageWidgetReference _lightStateImageWidget;
		private inkImageWidgetReference _cautionStateImageWidget;
		private CHandle<redCallbackObject> _lightStateBBConnectionId;
		private CHandle<redCallbackObject> _cautionStateBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;

		[Ordinal(1)] 
		[RED("lightStateImageWidget")] 
		public inkImageWidgetReference LightStateImageWidget
		{
			get => GetProperty(ref _lightStateImageWidget);
			set => SetProperty(ref _lightStateImageWidget, value);
		}

		[Ordinal(2)] 
		[RED("cautionStateImageWidget")] 
		public inkImageWidgetReference CautionStateImageWidget
		{
			get => GetProperty(ref _cautionStateImageWidget);
			set => SetProperty(ref _cautionStateImageWidget, value);
		}

		[Ordinal(3)] 
		[RED("lightStateBBConnectionId")] 
		public CHandle<redCallbackObject> LightStateBBConnectionId
		{
			get => GetProperty(ref _lightStateBBConnectionId);
			set => SetProperty(ref _lightStateBBConnectionId, value);
		}

		[Ordinal(4)] 
		[RED("cautionStateBBConnectionId")] 
		public CHandle<redCallbackObject> CautionStateBBConnectionId
		{
			get => GetProperty(ref _cautionStateBBConnectionId);
			set => SetProperty(ref _cautionStateBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		public instrumentPanelLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
