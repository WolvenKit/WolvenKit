using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessageMenuAttachmentData : IScriptable
	{
		[Ordinal(0)]  [RED("entryHash")] public CInt32 EntryHash { get; set; }

		public MessageMenuAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
