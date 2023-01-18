using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVoicesetComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("blockedInputs")] 
		public CArray<entVoicesetInputToBlock> BlockedInputs
		{
			get => GetPropertyValue<CArray<entVoicesetInputToBlock>>();
			set => SetPropertyValue<CArray<entVoicesetInputToBlock>>(value);
		}

		[Ordinal(1)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("NPCHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> NPCHighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(3)] 
		[RED("gruntSetIndex")] 
		public CUInt32 GruntSetIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("areVoicesetLinesEnabled")] 
		public CBool AreVoicesetLinesEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("areVoicesetGruntsEnabled")] 
		public CBool AreVoicesetGruntsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnVoicesetComponentPS()
		{
			BlockedInputs = new();
			NPCHighLevelState = Enums.gamedataNPCHighLevelState.Invalid;
			AreVoicesetLinesEnabled = true;
			AreVoicesetGruntsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
