using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleMedallion : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_fxSetFocusPointsSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

		[Ordinal(2)] [RED("m_fxSetVitalitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

		[Ordinal(3)] [RED("m_fxSetMedallionActiveSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMedallionActiveSFF { get; set;}

		[Ordinal(4)] [RED("m_fxSetMedallionThresholdSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMedallionThresholdSFF { get; set;}

		[Ordinal(5)] [RED("m_focusPoints")] 		public CInt32 M_focusPoints { get; set;}

		[Ordinal(6)] [RED("m_medallionActivated")] 		public CBool M_medallionActivated { get; set;}

		[Ordinal(7)] [RED("m_vitality")] 		public CFloat M_vitality { get; set;}

		[Ordinal(8)] [RED("m_maxVitality")] 		public CFloat M_maxVitality { get; set;}

		[Ordinal(9)] [RED("m_medallionThreshold")] 		public CFloat M_medallionThreshold { get; set;}

		public CR4HudModuleMedallion(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleMedallion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}