using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestPhaseBlock : CQuestScopeBlock
	{
		[RED("layersToLoad", 2,0)] 		public CArray<CString> LayersToLoad { get; set;}

		[RED("isBlackscreenPhase")] 		public CBool IsBlackscreenPhase { get; set;}

		[RED("blackscreenFadeDuration")] 		public CFloat BlackscreenFadeDuration { get; set;}

		[RED("saveMode")] 		public CEnum<EQuestPhaseSaveMode> SaveMode { get; set;}

		[RED("soundBanksDependency", 2,0)] 		public CArray<CName> SoundBanksDependency { get; set;}

		[RED("playGoChunk")] 		public CName PlayGoChunk { get; set;}

		[RED("purgeSavedData")] 		public CBool PurgeSavedData { get; set;}

		public CQuestPhaseBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestPhaseBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}