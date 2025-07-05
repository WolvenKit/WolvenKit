using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsBraindanceVisibilityEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("customMaterialParam")] 
		public CEnum<ECustomMaterialParam> CustomMaterialParam
		{
			get => GetPropertyValue<CEnum<ECustomMaterialParam>>();
			set => SetPropertyValue<CEnum<ECustomMaterialParam>>(value);
		}

		[Ordinal(8)] 
		[RED("parameterIndex")] 
		public CUInt32 ParameterIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(11)] 
		[RED("eventStartEndBlend")] 
		public CFloat EventStartEndBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("perspectiveBlend")] 
		public CFloat PerspectiveBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("renderSettingsFPP")] 
		public WorldRenderAreaSettings RenderSettingsFPP
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(14)] 
		[RED("renderSettingsTPP")] 
		public WorldRenderAreaSettings RenderSettingsTPP
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		public scneventsBraindanceVisibilityEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;
			PerformerId = new scnPerformerId { Id = 4294967040 };
			CustomMaterialParam = Enums.ECustomMaterialParam.ECMP_CustomParam0;
			Priority = 7;
			PerspectiveBlend = 0.500000F;
			RenderSettingsFPP = new WorldRenderAreaSettings { AreaParameters = new() };
			RenderSettingsTPP = new WorldRenderAreaSettings { AreaParameters = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
