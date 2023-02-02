using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioMixNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("mixSignpost")] 
		public CName MixSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questAudioMixNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
