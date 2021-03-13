using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionIconPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] [RED("iconRecord")] public wCHandle<gamedataChoiceCaptionIconPart_Record> IconRecord { get; set; }

		public gameinteractionsChoiceCaptionIconPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
