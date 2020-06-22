using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBuffs : CR4HudModuleBase
	{
		[RED("_currentEffects", 2,0)] 		public CArray<CHandle<CBaseGameplayEffect>> _currentEffects { get; set;}

		[RED("_previousEffects", 2,0)] 		public CArray<CHandle<CBaseGameplayEffect>> _previousEffects { get; set;}

		[RED("_forceUpdate")] 		public CBool _forceUpdate { get; set;}

		[RED("m_fxSetPercentSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPercentSFF { get; set;}

		[RED("m_fxShowBuffUpdateFx")] 		public CHandle<CScriptedFlashFunction> M_fxShowBuffUpdateFx { get; set;}

		[RED("m_fxsetViewMode")] 		public CHandle<CScriptedFlashFunction> M_fxsetViewMode { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("iCurrentEffectsSize")] 		public CInt32 ICurrentEffectsSize { get; set;}

		[RED("bDisplayBuffs")] 		public CBool BDisplayBuffs { get; set;}

		[RED("m_runword5Applied")] 		public CBool M_runword5Applied { get; set;}

		public CR4HudModuleBuffs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleBuffs(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}