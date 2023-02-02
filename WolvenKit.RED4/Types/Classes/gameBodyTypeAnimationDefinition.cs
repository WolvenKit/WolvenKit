using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBodyTypeAnimationDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceAsyncReference<animRig>>();
			set => SetPropertyValue<CResourceAsyncReference<animRig>>(value);
		}

		[Ordinal(1)] 
		[RED("animsets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> Animsets
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>(value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimationOverrideDefinition> Overrides
		{
			get => GetPropertyValue<CArray<gameAnimationOverrideDefinition>>();
			set => SetPropertyValue<CArray<gameAnimationOverrideDefinition>>(value);
		}

		public gameBodyTypeAnimationDefinition()
		{
			Animsets = new();
			Overrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
