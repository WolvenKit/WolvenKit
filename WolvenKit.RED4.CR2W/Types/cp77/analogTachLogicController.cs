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
		private CUInt32 _rpmValueBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private CFloat _rpmMaxValue;
		private CFloat _rpmMinValue;

		[Ordinal(1)] 
		[RED("analogTachNeedleWidget")] 
		public inkWidgetReference AnalogTachNeedleWidget
		{
			get
			{
				if (_analogTachNeedleWidget == null)
				{
					_analogTachNeedleWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "analogTachNeedleWidget", cr2w, this);
				}
				return _analogTachNeedleWidget;
			}
			set
			{
				if (_analogTachNeedleWidget == value)
				{
					return;
				}
				_analogTachNeedleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("analogTachNeedleMinRotation")] 
		public CFloat AnalogTachNeedleMinRotation
		{
			get
			{
				if (_analogTachNeedleMinRotation == null)
				{
					_analogTachNeedleMinRotation = (CFloat) CR2WTypeManager.Create("Float", "analogTachNeedleMinRotation", cr2w, this);
				}
				return _analogTachNeedleMinRotation;
			}
			set
			{
				if (_analogTachNeedleMinRotation == value)
				{
					return;
				}
				_analogTachNeedleMinRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("analogTachNeedleMaxRotation")] 
		public CFloat AnalogTachNeedleMaxRotation
		{
			get
			{
				if (_analogTachNeedleMaxRotation == null)
				{
					_analogTachNeedleMaxRotation = (CFloat) CR2WTypeManager.Create("Float", "analogTachNeedleMaxRotation", cr2w, this);
				}
				return _analogTachNeedleMaxRotation;
			}
			set
			{
				if (_analogTachNeedleMaxRotation == value)
				{
					return;
				}
				_analogTachNeedleMaxRotation = value;
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

		[Ordinal(7)] 
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

		public analogTachLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
