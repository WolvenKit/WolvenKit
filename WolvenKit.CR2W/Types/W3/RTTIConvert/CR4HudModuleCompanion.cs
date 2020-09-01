using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleCompanion : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("("m_fxSetNameSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetNameSFF { get; set;}

		[Ordinal(2)] [RED("("m_fxSetPortraitSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPortraitSFF { get; set;}

		[Ordinal(3)] [RED("("m_fxSetVitalitySFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

		[Ordinal(4)] [RED("("m_fxSetName2SFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetName2SFF { get; set;}

		[Ordinal(5)] [RED("("m_fxSetPortrait2SFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetPortrait2SFF { get; set;}

		[Ordinal(6)] [RED("("m_fxSetVitality2SFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitality2SFF { get; set;}

		[Ordinal(7)] [RED("("bShow")] 		public CBool BShow { get; set;}

		[Ordinal(8)] [RED("("m_LastVitality")] 		public CFloat M_LastVitality { get; set;}

		[Ordinal(9)] [RED("("m_LastMaxVitality")] 		public CFloat M_LastMaxVitality { get; set;}

		[Ordinal(10)] [RED("("m_LastVitality2")] 		public CFloat M_LastVitality2 { get; set;}

		[Ordinal(11)] [RED("("m_LastMaxVitality2")] 		public CFloat M_LastMaxVitality2 { get; set;}

		[Ordinal(12)] [RED("("companionNPC")] 		public CHandle<CNewNPC> CompanionNPC { get; set;}

		[Ordinal(13)] [RED("("companionNPC2")] 		public CHandle<CNewNPC> CompanionNPC2 { get; set;}

		[Ordinal(14)] [RED("("companionName")] 		public CString CompanionName { get; set;}

		[Ordinal(15)] [RED("("companionName2")] 		public CString CompanionName2 { get; set;}

		public CR4HudModuleCompanion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleCompanion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}