using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleAnchors : CR4HudModuleBase
	{
		[RED("m_fxUpdateAnchorsPositions")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateAnchorsPositions { get; set;}

		[RED("m_fxUpdateAnchorsAspectRatio")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

		public CR4HudModuleAnchors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleAnchors(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}