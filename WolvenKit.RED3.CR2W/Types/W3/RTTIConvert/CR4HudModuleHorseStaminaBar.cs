using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleHorseStaminaBar : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetStaminaSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

		[Ordinal(2)] [RED("_stamina")] 		public CFloat _stamina { get; set;}

		public CR4HudModuleHorseStaminaBar(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}