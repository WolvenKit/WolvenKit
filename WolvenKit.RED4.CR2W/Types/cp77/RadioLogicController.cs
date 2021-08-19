using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _radioTextWidget;
		private inkCanvasWidgetReference _radioEQWidget;
		private CHandle<redCallbackObject> _radioStateBBConnectionId;
		private CHandle<redCallbackObject> _radioNameBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private CHandle<inkanimProxy> _eqLoopAnimProxy;
		private Vector2 _radioTextWidgetSize;

		[Ordinal(1)] 
		[RED("radioTextWidget")] 
		public inkTextWidgetReference RadioTextWidget
		{
			get => GetProperty(ref _radioTextWidget);
			set => SetProperty(ref _radioTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("radioEQWidget")] 
		public inkCanvasWidgetReference RadioEQWidget
		{
			get => GetProperty(ref _radioEQWidget);
			set => SetProperty(ref _radioEQWidget, value);
		}

		[Ordinal(3)] 
		[RED("radioStateBBConnectionId")] 
		public CHandle<redCallbackObject> RadioStateBBConnectionId
		{
			get => GetProperty(ref _radioStateBBConnectionId);
			set => SetProperty(ref _radioStateBBConnectionId, value);
		}

		[Ordinal(4)] 
		[RED("radioNameBBConnectionId")] 
		public CHandle<redCallbackObject> RadioNameBBConnectionId
		{
			get => GetProperty(ref _radioNameBBConnectionId);
			set => SetProperty(ref _radioNameBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		[Ordinal(6)] 
		[RED("eqLoopAnimProxy")] 
		public CHandle<inkanimProxy> EqLoopAnimProxy
		{
			get => GetProperty(ref _eqLoopAnimProxy);
			set => SetProperty(ref _eqLoopAnimProxy, value);
		}

		[Ordinal(7)] 
		[RED("radioTextWidgetSize")] 
		public Vector2 RadioTextWidgetSize
		{
			get => GetProperty(ref _radioTextWidgetSize);
			set => SetProperty(ref _radioTextWidgetSize, value);
		}

		public RadioLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
