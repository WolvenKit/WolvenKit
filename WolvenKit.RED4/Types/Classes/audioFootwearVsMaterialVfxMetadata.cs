using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFootwearVsMaterialVfxMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("footwearType")] 
		public CName FootwearType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("defaultVfx")] 
		public CResourceAsyncReference<CResource> DefaultVfx
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(3)] 
		[RED("locomotionStates")] 
		public CHandle<audioLocomotionStateVfxDictionary> LocomotionStates
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateVfxDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateVfxDictionary>>(value);
		}

		[Ordinal(4)] 
		[RED("customActionVfx")] 
		public CHandle<audioLocomotionCustomActionVfxDictionary> CustomActionVfx
		{
			get => GetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionary>>(value);
		}

		public audioFootwearVsMaterialVfxMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
