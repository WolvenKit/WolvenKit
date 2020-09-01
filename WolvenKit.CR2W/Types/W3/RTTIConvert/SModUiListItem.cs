using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiListItem : CVariable
	{
		[Ordinal(0)] [RED("("id")] 		public CString Id { get; set;}

		[Ordinal(0)] [RED("("caption")] 		public CString Caption { get; set;}

		[Ordinal(0)] [RED("("isSelected")] 		public CBool IsSelected { get; set;}

		[Ordinal(0)] [RED("("prefix")] 		public CString Prefix { get; set;}

		[Ordinal(0)] [RED("("suffix")] 		public CString Suffix { get; set;}

		public SModUiListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiListItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}