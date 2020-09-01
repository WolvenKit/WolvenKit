using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4AutosaveWarningMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_fxSetDuration")] 		public CHandle<CScriptedFlashFunction> M_fxSetDuration { get; set;}

		[Ordinal(2)] [RED("m_fxSetAutosaveMessage")] 		public CHandle<CScriptedFlashFunction> M_fxSetAutosaveMessage { get; set;}

		public CR4AutosaveWarningMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4AutosaveWarningMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}