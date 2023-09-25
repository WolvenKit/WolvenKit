using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetPropertyValue<CArray<SVfxInstanceData>>();
			set => SetPropertyValue<CArray<SVfxInstanceData>>(value);
		}

		[Ordinal(6)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetPropertyValue<CArray<STransformAnimationData>>();
			set => SetPropertyValue<CArray<STransformAnimationData>>(value);
		}

		[Ordinal(7)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetPropertyValue<CArray<SVFXOperationData>>();
			set => SetPropertyValue<CArray<SVFXOperationData>>(value);
		}

		[Ordinal(8)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetPropertyValue<CArray<SSFXOperationData>>();
			set => SetPropertyValue<CArray<SSFXOperationData>>(value);
		}

		[Ordinal(9)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		[Ordinal(10)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetPropertyValue<CArray<SComponentOperationData>>();
			set => SetPropertyValue<CArray<SComponentOperationData>>(value);
		}

		[Ordinal(11)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetPropertyValue<CArray<SStimOperationData>>();
			set => SetPropertyValue<CArray<SStimOperationData>>(value);
		}

		[Ordinal(12)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetPropertyValue<CArray<SStatusEffectOperationData>>();
			set => SetPropertyValue<CArray<SStatusEffectOperationData>>(value);
		}

		[Ordinal(13)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetPropertyValue<CArray<SDamageOperationData>>();
			set => SetPropertyValue<CArray<SDamageOperationData>>(value);
		}

		[Ordinal(14)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetPropertyValue<CArray<SInventoryOperationData>>();
			set => SetPropertyValue<CArray<SInventoryOperationData>>(value);
		}

		[Ordinal(15)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetPropertyValue<STeleportOperationData>();
			set => SetPropertyValue<STeleportOperationData>(value);
		}

		[Ordinal(16)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetPropertyValue<SWorkspotData>();
			set => SetPropertyValue<SWorkspotData>(value);
		}

		public GenericDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			FxInstances = new();
			TransformAnimations = new();
			VFXs = new();
			SFXs = new();
			Facts = new();
			Components = new();
			Stims = new();
			StatusEffects = new();
			Damages = new();
			Items = new();
			Teleport = new STeleportOperationData();
			PlayerWorkspot = new SWorkspotData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
