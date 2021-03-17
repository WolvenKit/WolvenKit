using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tachometerLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _rpmValueWidget;
		private inkRectangleWidgetReference _rpmGaugeForegroundWidget;
		private CBool _scaleX;
		private CUInt32 _rpmValueBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private Vector2 _rpmGaugeMaxSize;
		private CFloat _rpmMaxValue;
		private CFloat _rpmMinValue;

		[Ordinal(1)] 
		[RED("rpmValueWidget")] 
		public inkTextWidgetReference RpmValueWidget
		{
			get => GetProperty(ref _rpmValueWidget);
			set => SetProperty(ref _rpmValueWidget, value);
		}

		[Ordinal(2)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get => GetProperty(ref _rpmGaugeForegroundWidget);
			set => SetProperty(ref _rpmGaugeForegroundWidget, value);
		}

		[Ordinal(3)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get => GetProperty(ref _scaleX);
			set => SetProperty(ref _scaleX, value);
		}

		[Ordinal(4)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
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
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetProperty(ref _rpmGaugeMaxSize);
			set => SetProperty(ref _rpmGaugeMaxSize, value);
		}

		[Ordinal(7)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetProperty(ref _rpmMaxValue);
			set => SetProperty(ref _rpmMaxValue, value);
		}

		[Ordinal(8)] 
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get => GetProperty(ref _rpmMinValue);
			set => SetProperty(ref _rpmMinValue, value);
		}

		public tachometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
