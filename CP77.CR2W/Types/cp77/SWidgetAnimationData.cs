using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SWidgetAnimationData : CVariable
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("lockWhenActive")] public CBool LockWhenActive { get; set; }
		[Ordinal(3)]  [RED("onEndLoop")] public CName OnEndLoop { get; set; }
		[Ordinal(4)]  [RED("onFinish")] public CName OnFinish { get; set; }
		[Ordinal(5)]  [RED("onPasue")] public CName OnPasue { get; set; }
		[Ordinal(6)]  [RED("onResume")] public CName OnResume { get; set; }
		[Ordinal(7)]  [RED("onStart")] public CName OnStart { get; set; }
		[Ordinal(8)]  [RED("onStartLoop")] public CName OnStartLoop { get; set; }
		[Ordinal(9)]  [RED("playbackOptions")] public inkanimPlaybackOptions PlaybackOptions { get; set; }

		public SWidgetAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
