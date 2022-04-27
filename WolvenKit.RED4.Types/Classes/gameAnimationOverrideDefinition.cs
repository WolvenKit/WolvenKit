using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimationOverrideDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animset")] 
		public CResourceAsyncReference<animAnimSet> Animset
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameAnimationOverrideDefinition()
		{
			Variables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
