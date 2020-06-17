using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiListItem : CVariable
	{
		[RED("id")] 		public CString Id { get; set;}

		[RED("caption")] 		public CString Caption { get; set;}

		[RED("isSelected")] 		public CBool IsSelected { get; set;}

		[RED("prefix")] 		public CString Prefix { get; set;}

		[RED("suffix")] 		public CString Suffix { get; set;}

		public SModUiListItem(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SModUiListItem(cr2w);

	}
}