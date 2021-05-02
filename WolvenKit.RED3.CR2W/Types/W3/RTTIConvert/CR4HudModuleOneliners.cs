using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleOneliners : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("m_hud")] 		public CHandle<CR4ScriptedHud> M_hud { get; set;}

		[Ordinal(2)] [RED("m_fxCreateOnelinerSFF")] 		public CHandle<CScriptedFlashFunction> M_fxCreateOnelinerSFF { get; set;}

		[Ordinal(3)] [RED("m_fxRemoveOnelinerSFF")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveOnelinerSFF { get; set;}

		[Ordinal(4)] [RED("m_flashModule")] 		public CHandle<CScriptedFlashSprite> M_flashModule { get; set;}

		[Ordinal(5)] [RED("m_oneliners", 2,0)] 		public CArray<OnelinerDefinition> M_oneliners { get; set;}

		[Ordinal(6)] [RED("VISIBILITY_DISTANCE_SQUARED")] 		public CFloat VISIBILITY_DISTANCE_SQUARED { get; set;}

		public CR4HudModuleOneliners(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleOneliners(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}