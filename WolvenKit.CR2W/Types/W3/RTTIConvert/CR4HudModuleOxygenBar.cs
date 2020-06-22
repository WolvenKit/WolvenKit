using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleOxygenBar : CR4HudModuleBase
	{
		[RED("m_fxSetOxygeneSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetOxygeneSFF { get; set;}

		[RED("oxygenePerc")] 		public CFloat OxygenePerc { get; set;}

		[RED("forceShowElement")] 		public CBool ForceShowElement { get; set;}

		[RED("bOxygeneBar")] 		public CBool BOxygeneBar { get; set;}

		[RED("bIsBarFull")] 		public CBool BIsBarFull { get; set;}

		[RED("isInGasArea")] 		public CBool IsInGasArea { get; set;}

		public CR4HudModuleOxygenBar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleOxygenBar(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}