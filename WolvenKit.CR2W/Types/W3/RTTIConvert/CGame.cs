using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGame : CObject
	{
		[RED("activeWorld")] 		public CHandle<CWorld> ActiveWorld { get; set;}

		[RED("visualDebug")] 		public CPtr<CVisualDebug> VisualDebug { get; set;}

		[RED("inputManager")] 		public CPtr<CInputManager> InputManager { get; set;}

		[RED("timerScriptKeyword")] 		public CPtr<CTimerScriptKeyword> TimerScriptKeyword { get; set;}

		[RED("gameResource")] 		public CHandle<CGameResource> GameResource { get; set;}

		public CGame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGame(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}