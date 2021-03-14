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
		private CUInt32 _lightStateBBConnectionId;
		private CUInt32 _cautionStateBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;

		[Ordinal(1)] 
		[RED("lightStateImageWidget")] 
		public inkImageWidgetReference LightStateImageWidget
		{
			get
			{
				if (_lightStateImageWidget == null)
				{
					_lightStateImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "lightStateImageWidget", cr2w, this);
				}
				return _lightStateImageWidget;
			}
			set
			{
				if (_lightStateImageWidget == value)
				{
					return;
				}
				_lightStateImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cautionStateImageWidget")] 
		public inkImageWidgetReference CautionStateImageWidget
		{
			get
			{
				if (_cautionStateImageWidget == null)
				{
					_cautionStateImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "cautionStateImageWidget", cr2w, this);
				}
				return _cautionStateImageWidget;
			}
			set
			{
				if (_cautionStateImageWidget == value)
				{
					return;
				}
				_cautionStateImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lightStateBBConnectionId")] 
		public CUInt32 LightStateBBConnectionId
		{
			get
			{
				if (_lightStateBBConnectionId == null)
				{
					_lightStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "lightStateBBConnectionId", cr2w, this);
				}
				return _lightStateBBConnectionId;
			}
			set
			{
				if (_lightStateBBConnectionId == value)
				{
					return;
				}
				_lightStateBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("cautionStateBBConnectionId")] 
		public CUInt32 CautionStateBBConnectionId
		{
			get
			{
				if (_cautionStateBBConnectionId == null)
				{
					_cautionStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "cautionStateBBConnectionId", cr2w, this);
				}
				return _cautionStateBBConnectionId;
			}
			set
			{
				if (_cautionStateBBConnectionId == value)
				{
					return;
				}
				_cautionStateBBConnectionId = value;
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

		public instrumentPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
