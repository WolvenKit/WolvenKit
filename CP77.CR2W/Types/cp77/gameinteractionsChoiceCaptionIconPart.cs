using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionIconPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)]  [RED("iconRecord")] public wCHandle<gamedataChoiceCaptionIconPart_Record> IconRecord { get; set; }

		public gameinteractionsChoiceCaptionIconPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
