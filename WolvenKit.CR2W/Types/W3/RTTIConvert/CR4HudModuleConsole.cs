using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleConsole : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("("m_fxHudConsoleMsg")] 		public CHandle<CScriptedFlashFunction> M_fxHudConsoleMsg { get; set;}

		[Ordinal(2)] [RED("("m_fxTestHudConsole")] 		public CHandle<CScriptedFlashFunction> M_fxTestHudConsole { get; set;}

		[Ordinal(3)] [RED("("m_fxCleanupHudConsole")] 		public CHandle<CScriptedFlashFunction> M_fxCleanupHudConsole { get; set;}

		[Ordinal(4)] [RED("("_iDuringDisplay")] 		public CInt32 _iDuringDisplay { get; set;}

		[Ordinal(5)] [RED("("MAX_CONSOLE_MESSEGES_DISPLAYED")] 		public CInt32 MAX_CONSOLE_MESSEGES_DISPLAYED { get; set;}

		[Ordinal(6)] [RED("("NEW_ITEM_DELAY")] 		public CFloat NEW_ITEM_DELAY { get; set;}

		[Ordinal(7)] [RED("("displayTime")] 		public CFloat DisplayTime { get; set;}

		[Ordinal(8)] [RED("("pendingMessages", 2,0)] 		public CArray<CString> PendingMessages { get; set;}

		public CR4HudModuleConsole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleConsole(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}