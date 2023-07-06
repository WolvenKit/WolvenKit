using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questChangeVoicesetState_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get => GetPropertyValue<CArray<entVoicesetInputToBlock>>();
			set => SetPropertyValue<CArray<entVoicesetInputToBlock>>(value);
		}

		public questChangeVoicesetState_NodeTypeParams()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			InputsToBlock = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
