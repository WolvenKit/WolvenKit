using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMenuTab : CVariable
	{
		[Ordinal(0)] [RED("("MenuName")] 		public CName MenuName { get; set;}

		[Ordinal(0)] [RED("("MenuLabel")] 		public CString MenuLabel { get; set;}

		[Ordinal(0)] [RED("("Visible")] 		public CBool Visible { get; set;}

		[Ordinal(0)] [RED("("Enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("Restricted")] 		public CBool Restricted { get; set;}

		[Ordinal(0)] [RED("("ParentMenu")] 		public CName ParentMenu { get; set;}

		[Ordinal(0)] [RED("("MenuState")] 		public CName MenuState { get; set;}

		public SMenuTab(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMenuTab(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}