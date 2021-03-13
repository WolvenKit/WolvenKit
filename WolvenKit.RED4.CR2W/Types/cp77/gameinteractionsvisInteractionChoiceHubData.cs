using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisInteractionChoiceHubData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)] [RED("flags")] public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags { get; set; }
		[Ordinal(2)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(3)] [RED("title")] public CString Title { get; set; }
		[Ordinal(4)] [RED("choices")] public CArray<gameinteractionsvisInteractionChoiceData> Choices { get; set; }
		[Ordinal(5)] [RED("timeProvider")] public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }

		public gameinteractionsvisInteractionChoiceHubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
