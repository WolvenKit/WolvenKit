using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiListItem : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CString Id { get; set;}

		[Ordinal(2)] [RED("caption")] 		public CString Caption { get; set;}

		[Ordinal(3)] [RED("isSelected")] 		public CBool IsSelected { get; set;}

		[Ordinal(4)] [RED("prefix")] 		public CString Prefix { get; set;}

		[Ordinal(5)] [RED("suffix")] 		public CString Suffix { get; set;}

		public SModUiListItem(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiListItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}