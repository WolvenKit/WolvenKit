using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleHorseStaminaBar : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetStaminaSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

		[Ordinal(2)] [RED("_stamina")] 		public CFloat _stamina { get; set;}

		public CR4HudModuleHorseStaminaBar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleHorseStaminaBar(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}