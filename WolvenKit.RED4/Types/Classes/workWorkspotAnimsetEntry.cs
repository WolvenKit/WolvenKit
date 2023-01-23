using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workWorkspotAnimsetEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceAsyncReference<animRig>>();
			set => SetPropertyValue<CResourceAsyncReference<animRig>>(value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetPropertyValue<animAnimSetup>();
			set => SetPropertyValue<animAnimSetup>(value);
		}

		[Ordinal(2)] 
		[RED("loadingHandles")] 
		public CArray<CResourceReference<animAnimSet>> LoadingHandles
		{
			get => GetPropertyValue<CArray<CResourceReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<animAnimSet>>>(value);
		}

		public workWorkspotAnimsetEntry()
		{
			Animations = new() { Cinematics = new(), Gameplay = new() };
			LoadingHandles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
