using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioGenericGameplayEventOccurredASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(0)]  [RED("gameplayEvent")] public CName GameplayEvent { get; set; }

		public audioGenericGameplayEventOccurredASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
