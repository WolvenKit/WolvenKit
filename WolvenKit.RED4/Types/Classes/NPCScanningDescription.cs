using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)] 
		[RED("NPCGameplayDescription")] 
		public TweakDBID NPCGameplayDescription
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("NPCCustomDescriptions")] 
		public CArray<TweakDBID> NPCCustomDescriptions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public NPCScanningDescription()
		{
			NPCCustomDescriptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
