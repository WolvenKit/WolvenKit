using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChangeHalfLights : redEvent
	{
		[Ordinal(0)]  [RED("isAuthorization")] public CBool IsAuthorization { get; set; }

		public ChangeHalfLights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
