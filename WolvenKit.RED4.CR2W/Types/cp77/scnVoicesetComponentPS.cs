using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVoicesetComponentPS : gameComponentPS
	{
		private CArray<entVoicesetInputToBlock> _blockedInputs;
		private CName _voiceTag;
		private CEnum<gamedataNPCHighLevelState> _nPCHighLevelState;
		private CUInt32 _gruntSetIndex;
		private CBool _areVoicesetLinesEnabled;
		private CBool _areVoicesetGruntsEnabled;

		[Ordinal(0)] 
		[RED("blockedInputs")] 
		public CArray<entVoicesetInputToBlock> BlockedInputs
		{
			get => GetProperty(ref _blockedInputs);
			set => SetProperty(ref _blockedInputs, value);
		}

		[Ordinal(1)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetProperty(ref _voiceTag);
			set => SetProperty(ref _voiceTag, value);
		}

		[Ordinal(2)] 
		[RED("NPCHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> NPCHighLevelState
		{
			get => GetProperty(ref _nPCHighLevelState);
			set => SetProperty(ref _nPCHighLevelState, value);
		}

		[Ordinal(3)] 
		[RED("gruntSetIndex")] 
		public CUInt32 GruntSetIndex
		{
			get => GetProperty(ref _gruntSetIndex);
			set => SetProperty(ref _gruntSetIndex, value);
		}

		[Ordinal(4)] 
		[RED("areVoicesetLinesEnabled")] 
		public CBool AreVoicesetLinesEnabled
		{
			get => GetProperty(ref _areVoicesetLinesEnabled);
			set => SetProperty(ref _areVoicesetLinesEnabled, value);
		}

		[Ordinal(5)] 
		[RED("areVoicesetGruntsEnabled")] 
		public CBool AreVoicesetGruntsEnabled
		{
			get => GetProperty(ref _areVoicesetGruntsEnabled);
			set => SetProperty(ref _areVoicesetGruntsEnabled, value);
		}

		public scnVoicesetComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
