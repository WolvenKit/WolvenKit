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
			get
			{
				if (_rpmValueWidget == null)
				{
					_rpmValueWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "rpmValueWidget", cr2w, this);
				}
				return _rpmValueWidget;
			}
			set
			{
				if (_rpmValueWidget == value)
				{
					return;
				}
				_rpmValueWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get
			{
				if (_rpmGaugeForegroundWidget == null)
				{
					_rpmGaugeForegroundWidget = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "rpmGaugeForegroundWidget", cr2w, this);
				}
				return _rpmGaugeForegroundWidget;
			}
			set
			{
				if (_rpmGaugeForegroundWidget == value)
				{
					return;
				}
				_rpmGaugeForegroundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get
			{
				if (_scaleX == null)
				{
					_scaleX = (CBool) CR2WTypeManager.Create("Bool", "scaleX", cr2w, this);
				}
				return _scaleX;
			}
			set
			{
				if (_scaleX == value)
				{
					return;
				}
				_scaleX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
		{
			get
			{
				if (_rpmValueBBConnectionId == null)
				{
					_rpmValueBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "rpmValueBBConnectionId", cr2w, this);
				}
				return _rpmValueBBConnectionId;
			}
			set
			{
				if (_rpmValueBBConnectionId == value)
				{
					return;
				}
				_rpmValueBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get
			{
				if (_vehBB == null)
				{
					_vehBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "vehBB", cr2w, this);
				}
				return _vehBB;
			}
			set
			{
				if (_vehBB == value)
				{
					return;
				}
				_vehBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get
			{
				if (_rpmGaugeMaxSize == null)
				{
					_rpmGaugeMaxSize = (Vector2) CR2WTypeManager.Create("Vector2", "rpmGaugeMaxSize", cr2w, this);
				}
				return _rpmGaugeMaxSize;
			}
			set
			{
				if (_rpmGaugeMaxSize == value)
				{
					return;
				}
				_rpmGaugeMaxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get
			{
				if (_rpmMaxValue == null)
				{
					_rpmMaxValue = (CFloat) CR2WTypeManager.Create("Float", "rpmMaxValue", cr2w, this);
				}
				return _rpmMaxValue;
			}
			set
			{
				if (_rpmMaxValue == value)
				{
					return;
				}
				_rpmMaxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get
			{
				if (_rpmMinValue == null)
				{
					_rpmMinValue = (CFloat) CR2WTypeManager.Create("Float", "rpmMinValue", cr2w, this);
				}
				return _rpmMinValue;
			}
			set
			{
				if (_rpmMinValue == value)
				{
					return;
				}
				_rpmMinValue = value;
				PropertySet(this);
			}
		}

		public tachometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
