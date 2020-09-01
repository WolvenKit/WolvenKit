using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGame : CObject
	{
		[Ordinal(1)] [RED("("activeWorld")] 		public CHandle<CWorld> ActiveWorld { get; set;}

		[Ordinal(2)] [RED("("visualDebug")] 		public CPtr<CVisualDebug> VisualDebug { get; set;}

		[Ordinal(3)] [RED("("inputManager")] 		public CPtr<CInputManager> InputManager { get; set;}

		[Ordinal(4)] [RED("("timerScriptKeyword")] 		public CPtr<CTimerScriptKeyword> TimerScriptKeyword { get; set;}

		[Ordinal(5)] [RED("("gameResource")] 		public CHandle<CGameResource> GameResource { get; set;}

		public CGame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGame(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}