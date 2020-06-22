using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleBase : CR4HudModule
	{
		[RED("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[RED("m_fxSetPlatform")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

		[RED("m_fxShowElementSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowElementSFF { get; set;}

		[RED("m_fxSetMaxOpacitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetMaxOpacitySFF { get; set;}

		[RED("m_fxSetEnabledSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetEnabledSFF { get; set;}

		[RED("m_fxSetScaleFromWSSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetScaleFromWSSFF { get; set;}

		[RED("m_fxShowTutorialHighlightSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowTutorialHighlightSFF { get; set;}

		[RED("m_anchorName")] 		public CString M_anchorName { get; set;}

		[RED("curResolutionWidth")] 		public CFloat CurResolutionWidth { get; set;}

		[RED("curResolutionHeight")] 		public CFloat CurResolutionHeight { get; set;}

		[RED("m_bEnabled")] 		public CBool M_bEnabled { get; set;}

		[RED("m_tickInterval")] 		public CFloat M_tickInterval { get; set;}

		[RED("m_tickCounter")] 		public CFloat M_tickCounter { get; set;}

		public CR4HudModuleBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}