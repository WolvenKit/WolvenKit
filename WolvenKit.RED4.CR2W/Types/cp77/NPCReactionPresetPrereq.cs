using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCReactionPresetPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataReactionPresetType> _reactionPreset;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("reactionPreset")] 
		public CEnum<gamedataReactionPresetType> ReactionPreset
		{
			get => GetProperty(ref _reactionPreset);
			set => SetProperty(ref _reactionPreset, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public NPCReactionPresetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
