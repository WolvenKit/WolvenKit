using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gearboxLogicController : IVehicleModuleController
	{
		private inkImageWidgetReference _gearboxRImageWidget;
		private inkImageWidgetReference _gearboxNImageWidget;
		private inkImageWidgetReference _gearboxDImageWidget;
		private CUInt32 _gearboxBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;

		[Ordinal(1)] 
		[RED("gearboxRImageWidget")] 
		public inkImageWidgetReference GearboxRImageWidget
		{
			get
			{
				if (_gearboxRImageWidget == null)
				{
					_gearboxRImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "gearboxRImageWidget", cr2w, this);
				}
				return _gearboxRImageWidget;
			}
			set
			{
				if (_gearboxRImageWidget == value)
				{
					return;
				}
				_gearboxRImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gearboxNImageWidget")] 
		public inkImageWidgetReference GearboxNImageWidget
		{
			get
			{
				if (_gearboxNImageWidget == null)
				{
					_gearboxNImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "gearboxNImageWidget", cr2w, this);
				}
				return _gearboxNImageWidget;
			}
			set
			{
				if (_gearboxNImageWidget == value)
				{
					return;
				}
				_gearboxNImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gearboxDImageWidget")] 
		public inkImageWidgetReference GearboxDImageWidget
		{
			get
			{
				if (_gearboxDImageWidget == null)
				{
					_gearboxDImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "gearboxDImageWidget", cr2w, this);
				}
				return _gearboxDImageWidget;
			}
			set
			{
				if (_gearboxDImageWidget == value)
				{
					return;
				}
				_gearboxDImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gearboxBBConnectionId")] 
		public CUInt32 GearboxBBConnectionId
		{
			get
			{
				if (_gearboxBBConnectionId == null)
				{
					_gearboxBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "gearboxBBConnectionId", cr2w, this);
				}
				return _gearboxBBConnectionId;
			}
			set
			{
				if (_gearboxBBConnectionId == value)
				{
					return;
				}
				_gearboxBBConnectionId = value;
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

		public gearboxLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
