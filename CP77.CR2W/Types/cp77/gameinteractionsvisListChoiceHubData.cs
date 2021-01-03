using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisListChoiceHubData : CVariable
	{
		[Ordinal(0)]  [RED("activityState")] public CEnum<gameinteractionsvisEVisualizerActivityState> ActivityState { get; set; }
		[Ordinal(1)]  [RED("choices")] public CArray<gameinteractionsvisListChoiceData> Choices { get; set; }
		[Ordinal(2)]  [RED("flags")] public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags { get; set; }
		[Ordinal(3)]  [RED("hubPriority")] public CUInt8 HubPriority { get; set; }
		[Ordinal(4)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(5)]  [RED("isPhoneLockActive")] public CBool IsPhoneLockActive { get; set; }
		[Ordinal(6)]  [RED("timeProvider")] public wCHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(7)]  [RED("title")] public CString Title { get; set; }

		public gameinteractionsvisListChoiceHubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
