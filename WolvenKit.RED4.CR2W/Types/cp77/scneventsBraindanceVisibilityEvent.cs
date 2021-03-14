using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsBraindanceVisibilityEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private CEnum<ECustomMaterialParam> _customMaterialParam;
		private CUInt32 _parameterIndex;
		private CBool _override;
		private CUInt8 _priority;
		private CFloat _eventStartEndBlend;
		private CFloat _perspectiveBlend;
		private WorldRenderAreaSettings _renderSettingsFPP;
		private WorldRenderAreaSettings _renderSettingsTPP;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("customMaterialParam")] 
		public CEnum<ECustomMaterialParam> CustomMaterialParam
		{
			get
			{
				if (_customMaterialParam == null)
				{
					_customMaterialParam = (CEnum<ECustomMaterialParam>) CR2WTypeManager.Create("ECustomMaterialParam", "customMaterialParam", cr2w, this);
				}
				return _customMaterialParam;
			}
			set
			{
				if (_customMaterialParam == value)
				{
					return;
				}
				_customMaterialParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("parameterIndex")] 
		public CUInt32 ParameterIndex
		{
			get
			{
				if (_parameterIndex == null)
				{
					_parameterIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "parameterIndex", cr2w, this);
				}
				return _parameterIndex;
			}
			set
			{
				if (_parameterIndex == value)
				{
					return;
				}
				_parameterIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("override")] 
		public CBool Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CBool) CR2WTypeManager.Create("Bool", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("eventStartEndBlend")] 
		public CFloat EventStartEndBlend
		{
			get
			{
				if (_eventStartEndBlend == null)
				{
					_eventStartEndBlend = (CFloat) CR2WTypeManager.Create("Float", "eventStartEndBlend", cr2w, this);
				}
				return _eventStartEndBlend;
			}
			set
			{
				if (_eventStartEndBlend == value)
				{
					return;
				}
				_eventStartEndBlend = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("perspectiveBlend")] 
		public CFloat PerspectiveBlend
		{
			get
			{
				if (_perspectiveBlend == null)
				{
					_perspectiveBlend = (CFloat) CR2WTypeManager.Create("Float", "perspectiveBlend", cr2w, this);
				}
				return _perspectiveBlend;
			}
			set
			{
				if (_perspectiveBlend == value)
				{
					return;
				}
				_perspectiveBlend = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("renderSettingsFPP")] 
		public WorldRenderAreaSettings RenderSettingsFPP
		{
			get
			{
				if (_renderSettingsFPP == null)
				{
					_renderSettingsFPP = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "renderSettingsFPP", cr2w, this);
				}
				return _renderSettingsFPP;
			}
			set
			{
				if (_renderSettingsFPP == value)
				{
					return;
				}
				_renderSettingsFPP = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("renderSettingsTPP")] 
		public WorldRenderAreaSettings RenderSettingsTPP
		{
			get
			{
				if (_renderSettingsTPP == null)
				{
					_renderSettingsTPP = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "renderSettingsTPP", cr2w, this);
				}
				return _renderSettingsTPP;
			}
			set
			{
				if (_renderSettingsTPP == value)
				{
					return;
				}
				_renderSettingsTPP = value;
				PropertySet(this);
			}
		}

		public scneventsBraindanceVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
