using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleMedallion : CR4HudModuleBase
	{
		[RED("m_fxSetFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

		[RED("m_fxSetVitalitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

		[RED("m_fxSetMedallionActiveSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMedallionActiveSFF { get; set;}

		[RED("m_fxSetMedallionThresholdSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMedallionThresholdSFF { get; set;}

		[RED("m_focusPoints")] 		public CInt32 M_focusPoints { get; set;}

		[RED("m_medallionActivated")] 		public CBool M_medallionActivated { get; set;}

		[RED("m_vitality")] 		public CFloat M_vitality { get; set;}

		[RED("m_maxVitality")] 		public CFloat M_maxVitality { get; set;}

		[RED("m_medallionThreshold")] 		public CFloat M_medallionThreshold { get; set;}

		public CR4HudModuleMedallion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleMedallion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}