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
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("customMaterialParam")] 
		public CEnum<ECustomMaterialParam> CustomMaterialParam
		{
			get => GetProperty(ref _customMaterialParam);
			set => SetProperty(ref _customMaterialParam, value);
		}

		[Ordinal(8)] 
		[RED("parameterIndex")] 
		public CUInt32 ParameterIndex
		{
			get => GetProperty(ref _parameterIndex);
			set => SetProperty(ref _parameterIndex, value);
		}

		[Ordinal(9)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(10)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(11)] 
		[RED("eventStartEndBlend")] 
		public CFloat EventStartEndBlend
		{
			get => GetProperty(ref _eventStartEndBlend);
			set => SetProperty(ref _eventStartEndBlend, value);
		}

		[Ordinal(12)] 
		[RED("perspectiveBlend")] 
		public CFloat PerspectiveBlend
		{
			get => GetProperty(ref _perspectiveBlend);
			set => SetProperty(ref _perspectiveBlend, value);
		}

		[Ordinal(13)] 
		[RED("renderSettingsFPP")] 
		public WorldRenderAreaSettings RenderSettingsFPP
		{
			get => GetProperty(ref _renderSettingsFPP);
			set => SetProperty(ref _renderSettingsFPP, value);
		}

		[Ordinal(14)] 
		[RED("renderSettingsTPP")] 
		public WorldRenderAreaSettings RenderSettingsTPP
		{
			get => GetProperty(ref _renderSettingsTPP);
			set => SetProperty(ref _renderSettingsTPP, value);
		}

		public scneventsBraindanceVisibilityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
