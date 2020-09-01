using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleDeathScreen : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetShowBlackscreenSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetShowBlackscreenSFF { get; set;}

		[Ordinal(2)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(3)] [RED("hasSaveData")] 		public CBool HasSaveData { get; set;}

		[Ordinal(4)] [RED("isOpened")] 		public CBool IsOpened { get; set;}

		public CR4HudModuleDeathScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleDeathScreen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}