using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		[Ordinal(0)]  [RED("data")] public ElementData Data { get; set; }
		[Ordinal(1)]  [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(2)]  [RED("textNormalColor")] public CColor TextNormalColor { get; set; }
		[Ordinal(3)]  [RED("textHighlightColor")] public CColor TextHighlightColor { get; set; }
		[Ordinal(4)]  [RED("bg")] public inkRectangleWidgetReference Bg { get; set; }
		[Ordinal(5)]  [RED("colorAccent")] public inkWidgetReference ColorAccent { get; set; }
		[Ordinal(6)]  [RED("dimmedOpacity")] public CFloat DimmedOpacity { get; set; }
		[Ordinal(7)]  [RED("notDimmedOpacity")] public CFloat NotDimmedOpacity { get; set; }
		[Ordinal(8)]  [RED("defaultFontSize")] public CInt32 DefaultFontSize { get; set; }
		[Ordinal(9)]  [RED("wasConsumed")] public CBool WasConsumed { get; set; }
		[Ordinal(10)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(11)]  [RED("onConsumeAnimation")] public CName OnConsumeAnimation { get; set; }
		[Ordinal(12)]  [RED("onSetContentAnimation")] public CName OnSetContentAnimation { get; set; }
		[Ordinal(13)]  [RED("onHighlightOnAnimation")] public CName OnHighlightOnAnimation { get; set; }
		[Ordinal(14)]  [RED("onHighlightOffAnimation")] public CName OnHighlightOffAnimation { get; set; }

		public NetworkMinigameAnimatedElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
