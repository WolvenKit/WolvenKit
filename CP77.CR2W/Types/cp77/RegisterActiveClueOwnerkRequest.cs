using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RegisterActiveClueOwnerkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public RegisterActiveClueOwnerkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
