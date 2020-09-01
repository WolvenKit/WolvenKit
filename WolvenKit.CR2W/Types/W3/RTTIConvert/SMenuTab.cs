using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMenuTab : CVariable
	{
		[Ordinal(1)] [RED("MenuName")] 		public CName MenuName { get; set;}

		[Ordinal(2)] [RED("MenuLabel")] 		public CString MenuLabel { get; set;}

		[Ordinal(3)] [RED("Visible")] 		public CBool Visible { get; set;}

		[Ordinal(4)] [RED("Enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(5)] [RED("Restricted")] 		public CBool Restricted { get; set;}

		[Ordinal(6)] [RED("ParentMenu")] 		public CName ParentMenu { get; set;}

		[Ordinal(7)] [RED("MenuState")] 		public CName MenuState { get; set;}

		public SMenuTab(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMenuTab(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}