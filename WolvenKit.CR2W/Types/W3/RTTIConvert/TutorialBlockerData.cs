using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TutorialBlockerData : TextPopupData
	{
		[Ordinal(1)] [RED("m_title")] 		public CString M_title { get; set;}

		[Ordinal(2)] [RED("m_description")] 		public CString M_description { get; set;}

		[Ordinal(3)] [RED("m_imagepath")] 		public CString M_imagepath { get; set;}

		[Ordinal(4)] [RED("scriptTag")] 		public CName ScriptTag { get; set;}

		[Ordinal(5)] [RED("managerRef")] 		public CHandle<CR4TutorialSystem> ManagerRef { get; set;}

		public TutorialBlockerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TutorialBlockerData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}