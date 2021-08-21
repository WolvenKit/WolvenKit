using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class analogTachLogicController : IVehicleModuleController
	{
		private inkWidgetReference _analogTachNeedleWidget;
		private CFloat _analogTachNeedleMinRotation;
		private CFloat _analogTachNeedleMaxRotation;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private CFloat _rpmMaxValue;
		private CFloat _rpmMinValue;

		[Ordinal(1)] 
		[RED("analogTachNeedleWidget")] 
		public inkWidgetReference AnalogTachNeedleWidget
		{
			get => GetProperty(ref _analogTachNeedleWidget);
			set => SetProperty(ref _analogTachNeedleWidget, value);
		}

		[Ordinal(2)] 
		[RED("analogTachNeedleMinRotation")] 
		public CFloat AnalogTachNeedleMinRotation
		{
			get => GetProperty(ref _analogTachNeedleMinRotation);
			set => SetProperty(ref _analogTachNeedleMinRotation, value);
		}

		[Ordinal(3)] 
		[RED("analogTachNeedleMaxRotation")] 
		public CFloat AnalogTachNeedleMaxRotation
		{
			get => GetProperty(ref _analogTachNeedleMaxRotation);
			set => SetProperty(ref _analogTachNeedleMaxRotation, value);
		}

		[Ordinal(4)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		[Ordinal(6)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetProperty(ref _rpmMaxValue);
			set => SetProperty(ref _rpmMaxValue, value);
		}

		[Ordinal(7)] 
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get => GetProperty(ref _rpmMinValue);
			set => SetProperty(ref _rpmMinValue, value);
		}

		public analogTachLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
