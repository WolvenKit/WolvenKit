using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleSignInfo : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("_iconName")] 		public CString _iconName { get; set;}

		[Ordinal(2)] [RED("_CurrentSelectedSign")] 		public CEnum<ESignType> _CurrentSelectedSign { get; set;}

		[Ordinal(3)] [RED("m_fxShowBckArrowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowBckArrowSFF { get; set;}

		[Ordinal(4)] [RED("m_fxEnableSFF")] 		public CHandle<CScriptedFlashFunction> M_fxEnableSFF { get; set;}

		public CR4HudModuleSignInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleSignInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}