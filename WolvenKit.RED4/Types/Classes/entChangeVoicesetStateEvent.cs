using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entChangeVoicesetStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get => GetPropertyValue<CArray<entVoicesetInputToBlock>>();
			set => SetPropertyValue<CArray<entVoicesetInputToBlock>>(value);
		}

		public entChangeVoicesetStateEvent()
		{
			EnableVoicesetLines = true;
			EnableVoicesetGrunts = true;
			InputsToBlock = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
