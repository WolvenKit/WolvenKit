using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCutsceneActorDef : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("("tag")] 		public TagList Tag { get; set;}

		[Ordinal(0)] [RED("("voiceTag")] 		public CName VoiceTag { get; set;}

		[Ordinal(0)] [RED("("template")] 		public CSoft<CEntityTemplate> Template { get; set;}

		[Ordinal(0)] [RED("("appearance")] 		public CName Appearance { get; set;}

		[Ordinal(0)] [RED("("type")] 		public CEnum<ECutsceneActorType> Type { get; set;}

		[Ordinal(0)] [RED("("finalPosition")] 		public TagList FinalPosition { get; set;}

		[Ordinal(0)] [RED("("killMe")] 		public CBool KillMe { get; set;}

		[Ordinal(0)] [RED("("useMimic")] 		public CBool UseMimic { get; set;}

		[Ordinal(0)] [RED("("animationAtFinalPosition")] 		public CName AnimationAtFinalPosition { get; set;}

		public SCutsceneActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCutsceneActorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}