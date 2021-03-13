using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIVideoPlayer : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("videoWidgetPath")] public CName VideoWidgetPath { get; set; }
		[Ordinal(2)] [RED("counterWidgetPath")] public CName CounterWidgetPath { get; set; }
		[Ordinal(3)] [RED("lastFramePath")] public CName LastFramePath { get; set; }
		[Ordinal(4)] [RED("currentFramePath")] public CName CurrentFramePath { get; set; }
		[Ordinal(5)] [RED("videoWidget")] public wCHandle<inkVideoWidget> VideoWidget { get; set; }
		[Ordinal(6)] [RED("framesToSkipCounterWidget")] public wCHandle<inkTextWidget> FramesToSkipCounterWidget { get; set; }
		[Ordinal(7)] [RED("lastFrameWidget")] public wCHandle<inkTextWidget> LastFrameWidget { get; set; }
		[Ordinal(8)] [RED("currentFrameWidget")] public wCHandle<inkTextWidget> CurrentFrameWidget { get; set; }
		[Ordinal(9)] [RED("numberOfFrames")] public CUInt32 NumberOfFrames { get; set; }

		public sampleUIVideoPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
