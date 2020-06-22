using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBossFocus : CR4HudModuleBase
	{
		[RED("m_bossEntity")] 		public CHandle<CActor> M_bossEntity { get; set;}

		[RED("m_bossName")] 		public CString M_bossName { get; set;}

		[RED("m_fxSetBossName")] 		public CHandle<CScriptedFlashFunction> M_fxSetBossName { get; set;}

		[RED("m_fxSetBossHealth")] 		public CHandle<CScriptedFlashFunction> M_fxSetBossHealth { get; set;}

		[RED("m_fxSetEssenceDamage")] 		public CHandle<CScriptedFlashFunction> M_fxSetEssenceDamage { get; set;}

		[RED("m_lastHealthPercentage")] 		public CInt32 M_lastHealthPercentage { get; set;}

		[RED("m_delay")] 		public CFloat M_delay { get; set;}

		public CR4HudModuleBossFocus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleBossFocus(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}