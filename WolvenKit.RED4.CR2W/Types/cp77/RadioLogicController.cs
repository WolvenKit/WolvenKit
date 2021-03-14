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
		private CUInt32 _radioStateBBConnectionId;
		private CUInt32 _radioNameBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private CHandle<inkanimProxy> _eqLoopAnimProxy;
		private Vector2 _radioTextWidgetSize;

		[Ordinal(1)] 
		[RED("radioTextWidget")] 
		public inkTextWidgetReference RadioTextWidget
		{
			get
			{
				if (_radioTextWidget == null)
				{
					_radioTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "radioTextWidget", cr2w, this);
				}
				return _radioTextWidget;
			}
			set
			{
				if (_radioTextWidget == value)
				{
					return;
				}
				_radioTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radioEQWidget")] 
		public inkCanvasWidgetReference RadioEQWidget
		{
			get
			{
				if (_radioEQWidget == null)
				{
					_radioEQWidget = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "radioEQWidget", cr2w, this);
				}
				return _radioEQWidget;
			}
			set
			{
				if (_radioEQWidget == value)
				{
					return;
				}
				_radioEQWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radioStateBBConnectionId")] 
		public CUInt32 RadioStateBBConnectionId
		{
			get
			{
				if (_radioStateBBConnectionId == null)
				{
					_radioStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "radioStateBBConnectionId", cr2w, this);
				}
				return _radioStateBBConnectionId;
			}
			set
			{
				if (_radioStateBBConnectionId == value)
				{
					return;
				}
				_radioStateBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("radioNameBBConnectionId")] 
		public CUInt32 RadioNameBBConnectionId
		{
			get
			{
				if (_radioNameBBConnectionId == null)
				{
					_radioNameBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "radioNameBBConnectionId", cr2w, this);
				}
				return _radioNameBBConnectionId;
			}
			set
			{
				if (_radioNameBBConnectionId == value)
				{
					return;
				}
				_radioNameBBConnectionId = value;
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
		[RED("eqLoopAnimProxy")] 
		public CHandle<inkanimProxy> EqLoopAnimProxy
		{
			get
			{
				if (_eqLoopAnimProxy == null)
				{
					_eqLoopAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "eqLoopAnimProxy", cr2w, this);
				}
				return _eqLoopAnimProxy;
			}
			set
			{
				if (_eqLoopAnimProxy == value)
				{
					return;
				}
				_eqLoopAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("radioTextWidgetSize")] 
		public Vector2 RadioTextWidgetSize
		{
			get
			{
				if (_radioTextWidgetSize == null)
				{
					_radioTextWidgetSize = (Vector2) CR2WTypeManager.Create("Vector2", "radioTextWidgetSize", cr2w, this);
				}
				return _radioTextWidgetSize;
			}
			set
			{
				if (_radioTextWidgetSize == value)
				{
					return;
				}
				_radioTextWidgetSize = value;
				PropertySet(this);
			}
		}

		public RadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
