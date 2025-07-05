using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioSwitchNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("switch")] 
		public audioAudSwitch Switch
		{
			get => GetPropertyValue<audioAudSwitch>();
			set => SetPropertyValue<audioAudSwitch>(value);
		}

		[Ordinal(1)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questAudioSwitchNodeType()
		{
			Switch = new audioAudSwitch();
			ObjectRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
