using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneMessage : gameJournalEntry
	{
		[Ordinal(0)]  [RED("attachment")] public CHandle<gameJournalPath> Attachment { get; set; }
		[Ordinal(1)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(2)]  [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(3)]  [RED("sender")] public CEnum<gameMessageSender> Sender { get; set; }
		[Ordinal(4)]  [RED("text")] public LocalizationString Text { get; set; }

		public gameJournalPhoneMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
