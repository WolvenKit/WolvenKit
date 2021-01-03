using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioGameplayTierActivatedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(0)]  [RED("gameplayTier")] public CEnum<audioGameplayTier> GameplayTier { get; set; }

		public audioGameplayTierActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
