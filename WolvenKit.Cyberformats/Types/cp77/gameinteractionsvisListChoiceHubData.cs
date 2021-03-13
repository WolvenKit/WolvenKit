using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceHubData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)] [RED("activityState")] public CEnum<gameinteractionsvisEVisualizerActivityState> ActivityState { get; set; }
		[Ordinal(2)] [RED("flags")] public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags { get; set; }
		[Ordinal(3)] [RED("isPhoneLockActive")] public CBool IsPhoneLockActive { get; set; }
		[Ordinal(4)] [RED("title")] public CString Title { get; set; }
		[Ordinal(5)] [RED("choices")] public CArray<gameinteractionsvisListChoiceData> Choices { get; set; }
		[Ordinal(6)] [RED("timeProvider")] public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(7)] [RED("hubPriority")] public CUInt8 HubPriority { get; set; }

		public gameinteractionsvisListChoiceHubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
