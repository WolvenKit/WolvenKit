using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TutorialBlockerData : TextPopupData
	{
		[RED("m_title")] 		public CString M_title { get; set;}

		[RED("m_description")] 		public CString M_description { get; set;}

		[RED("m_imagepath")] 		public CString M_imagepath { get; set;}

		[RED("scriptTag")] 		public CName ScriptTag { get; set;}

		[RED("managerRef")] 		public CHandle<CR4TutorialSystem> ManagerRef { get; set;}

		public TutorialBlockerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TutorialBlockerData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}