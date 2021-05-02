using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBase : CR4HudModule
	{
		[Ordinal(1)] [RED("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[Ordinal(2)] [RED("m_fxSetPlatform")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

		[Ordinal(3)] [RED("m_fxShowElementSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowElementSFF { get; set;}

		[Ordinal(4)] [RED("m_fxSetMaxOpacitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMaxOpacitySFF { get; set;}

		[Ordinal(5)] [RED("m_fxSetEnabledSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnabledSFF { get; set;}

		[Ordinal(6)] [RED("m_fxSetScaleFromWSSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetScaleFromWSSFF { get; set;}

		[Ordinal(7)] [RED("m_fxShowTutorialHighlightSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowTutorialHighlightSFF { get; set;}

		[Ordinal(8)] [RED("m_anchorName")] 		public CString M_anchorName { get; set;}

		[Ordinal(9)] [RED("curResolutionWidth")] 		public CFloat CurResolutionWidth { get; set;}

		[Ordinal(10)] [RED("curResolutionHeight")] 		public CFloat CurResolutionHeight { get; set;}

		[Ordinal(11)] [RED("m_bEnabled")] 		public CBool M_bEnabled { get; set;}

		[Ordinal(12)] [RED("m_tickInterval")] 		public CFloat M_tickInterval { get; set;}

		[Ordinal(13)] [RED("m_tickCounter")] 		public CFloat M_tickCounter { get; set;}

		public CR4HudModuleBase(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}