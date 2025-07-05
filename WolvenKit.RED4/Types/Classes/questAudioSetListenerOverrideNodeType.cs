using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioSetListenerOverrideNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questAudioSetListenerOverrideNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
