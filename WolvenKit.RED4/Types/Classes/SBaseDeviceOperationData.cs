using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBaseDeviceOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("resetDelay")] 
		public CBool ResetDelay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetPropertyValue<CArray<STransformAnimationData>>();
			set => SetPropertyValue<CArray<STransformAnimationData>>(value);
		}

		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetPropertyValue<CArray<SVFXOperationData>>();
			set => SetPropertyValue<CArray<SVFXOperationData>>(value);
		}

		[Ordinal(6)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetPropertyValue<CArray<SSFXOperationData>>();
			set => SetPropertyValue<CArray<SSFXOperationData>>(value);
		}

		[Ordinal(7)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetPropertyValue<CArray<SFactOperationData>>();
			set => SetPropertyValue<CArray<SFactOperationData>>(value);
		}

		[Ordinal(8)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetPropertyValue<CArray<SComponentOperationData>>();
			set => SetPropertyValue<CArray<SComponentOperationData>>(value);
		}

		[Ordinal(9)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetPropertyValue<CArray<SStimOperationData>>();
			set => SetPropertyValue<CArray<SStimOperationData>>(value);
		}

		[Ordinal(10)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetPropertyValue<CArray<SStatusEffectOperationData>>();
			set => SetPropertyValue<CArray<SStatusEffectOperationData>>(value);
		}

		[Ordinal(11)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetPropertyValue<CArray<SDamageOperationData>>();
			set => SetPropertyValue<CArray<SDamageOperationData>>(value);
		}

		[Ordinal(12)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetPropertyValue<CArray<SInventoryOperationData>>();
			set => SetPropertyValue<CArray<SInventoryOperationData>>(value);
		}

		[Ordinal(13)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetPropertyValue<STeleportOperationData>();
			set => SetPropertyValue<STeleportOperationData>(value);
		}

		[Ordinal(14)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetPropertyValue<SWorkspotData>();
			set => SetPropertyValue<SWorkspotData>(value);
		}

		[Ordinal(16)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("toggleOperations")] 
		public CArray<SToggleOperationData> ToggleOperations
		{
			get => GetPropertyValue<CArray<SToggleOperationData>>();
			set => SetPropertyValue<CArray<SToggleOperationData>>(value);
		}

		[Ordinal(18)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(20)] 
		[RED("isDelayActive")] 
		public CBool IsDelayActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SBaseDeviceOperationData()
		{
			IsEnabled = true;
			TransformAnimations = new();
			VFXs = new();
			SFXs = new();
			Facts = new();
			Components = new();
			Stims = new();
			StatusEffects = new();
			Damages = new();
			Items = new();
			Teleport = new();
			PlayerWorkspot = new();
			ToggleOperations = new();
			DelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
