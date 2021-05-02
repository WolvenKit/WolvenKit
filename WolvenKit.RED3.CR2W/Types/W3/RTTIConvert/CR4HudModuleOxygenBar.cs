using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleOxygenBar : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetOxygeneSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetOxygeneSFF { get; set;}

		[Ordinal(2)] [RED("oxygenePerc")] 		public CFloat OxygenePerc { get; set;}

		[Ordinal(3)] [RED("forceShowElement")] 		public CBool ForceShowElement { get; set;}

		[Ordinal(4)] [RED("bOxygeneBar")] 		public CBool BOxygeneBar { get; set;}

		[Ordinal(5)] [RED("bIsBarFull")] 		public CBool BIsBarFull { get; set;}

		[Ordinal(6)] [RED("isInGasArea")] 		public CBool IsInGasArea { get; set;}

		public CR4HudModuleOxygenBar(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleOxygenBar(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}