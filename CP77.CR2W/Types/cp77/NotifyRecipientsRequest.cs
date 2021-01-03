using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NotifyRecipientsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("recipients")] public CArray<RecipientData> Recipients { get; set; }
		[Ordinal(1)]  [RED("time")] public GameTime Time { get; set; }

		public NotifyRecipientsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
