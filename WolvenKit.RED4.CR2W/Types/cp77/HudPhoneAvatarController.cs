using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HudPhoneAvatarController : HUDPhoneElement
	{
		[Ordinal(2)] [RED("ContactAvatar")] public inkImageWidgetReference ContactAvatar { get; set; }
		[Ordinal(3)] [RED("HolocallRenderTexture")] public inkImageWidgetReference HolocallRenderTexture { get; set; }
		[Ordinal(4)] [RED("SignalRangeIcon")] public inkImageWidgetReference SignalRangeIcon { get; set; }
		[Ordinal(5)] [RED("ContactName")] public inkTextWidgetReference ContactName { get; set; }
		[Ordinal(6)] [RED("StatusText")] public inkTextWidgetReference StatusText { get; set; }
		[Ordinal(7)] [RED("WaveformPlaceholder")] public inkCanvasWidgetReference WaveformPlaceholder { get; set; }
		[Ordinal(8)] [RED("HolocallHolder")] public inkFlexWidgetReference HolocallHolder { get; set; }
		[Ordinal(9)] [RED("UnknownAvatarName")] public CName UnknownAvatarName { get; set; }
		[Ordinal(10)] [RED("DefaultPortraitColor")] public CColor DefaultPortraitColor { get; set; }
		[Ordinal(11)] [RED("DefaultImageSize")] public Vector2 DefaultImageSize { get; set; }
		[Ordinal(12)] [RED("LoopAnimationName")] public CName LoopAnimationName { get; set; }
		[Ordinal(13)] [RED("ShowingAnimationName")] public CName ShowingAnimationName { get; set; }
		[Ordinal(14)] [RED("HidingAnimationName")] public CName HidingAnimationName { get; set; }
		[Ordinal(15)] [RED("AudiocallShowingAnimationName")] public CName AudiocallShowingAnimationName { get; set; }
		[Ordinal(16)] [RED("AudiocallHidingAnimationName")] public CName AudiocallHidingAnimationName { get; set; }
		[Ordinal(17)] [RED("HolocallShowingAnimationName")] public CName HolocallShowingAnimationName { get; set; }
		[Ordinal(18)] [RED("HolocallHidingAnimationName")] public CName HolocallHidingAnimationName { get; set; }
		[Ordinal(19)] [RED("LoopAnimation")] public CHandle<inkanimProxy> LoopAnimation { get; set; }
		[Ordinal(20)] [RED("options")] public inkanimPlaybackOptions Options { get; set; }
		[Ordinal(21)] [RED("JournalManager")] public CHandle<gameIJournalManager> JournalManager { get; set; }
		[Ordinal(22)] [RED("RootAnimation")] public CHandle<inkanimProxy> RootAnimation { get; set; }
		[Ordinal(23)] [RED("AudiocallAnimation")] public CHandle<inkanimProxy> AudiocallAnimation { get; set; }
		[Ordinal(24)] [RED("HolocallAnimation")] public CHandle<inkanimProxy> HolocallAnimation { get; set; }
		[Ordinal(25)] [RED("Holder")] public inkWidgetReference Holder { get; set; }
		[Ordinal(26)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(27)] [RED("CurrentMode")] public CEnum<EHudAvatarMode> CurrentMode { get; set; }
		[Ordinal(28)] [RED("Minimized")] public CBool Minimized { get; set; }

		public HudPhoneAvatarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
