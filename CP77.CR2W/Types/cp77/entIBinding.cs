using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entIBinding : ISerializable
	{
		[Ordinal(0)]  [RED("bindName")] public CName BindName { get; set; }
		[Ordinal(1)]  [RED("enableMask")] public entTagMask EnableMask { get; set; }
		[Ordinal(2)]  [RED("enabled")] public CBool Enabled { get; set; }

		public entIBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
