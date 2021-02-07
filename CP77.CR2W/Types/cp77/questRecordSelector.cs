using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRecordSelector : ISerializable
	{
		[Ordinal(0)]  [RED("isCharacter")] public CBool IsCharacter { get; set; }
		[Ordinal(1)]  [RED("characterRecordID")] public TweakDBID CharacterRecordID { get; set; }
		[Ordinal(2)]  [RED("isDevice")] public CBool IsDevice { get; set; }
		[Ordinal(3)]  [RED("deviceRecordID")] public TweakDBID DeviceRecordID { get; set; }
		[Ordinal(4)]  [RED("isItem")] public CBool IsItem { get; set; }
		[Ordinal(5)]  [RED("itemRecordID")] public TweakDBID ItemRecordID { get; set; }

		public questRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
