using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDefaultMixingSignposts : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("endOfCombat")] 
		public CName EndOfCombat
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("inCombat")] 
		public CName InCombat
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("inStealth")] 
		public CName InStealth
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("aiAlerted")] 
		public CName AiAlerted
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("sceneBootstrapSignpost")] 
		public CName SceneBootstrapSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("reservedSignposts")] 
		public CArray<CName> ReservedSignposts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioDefaultMixingSignposts()
		{
			EndOfCombat = "combat_ended";
			InCombat = "in_combat";
			InStealth = "in_stealth";
			AiAlerted = "ai_alerted";
			ReservedSignposts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
