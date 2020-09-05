using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCutsceneActorDef : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("tag")] 		public TagList Tag { get; set;}

		[Ordinal(3)] [RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[Ordinal(4)] [RED("template")] 		public CSoft<CEntityTemplate> Template { get; set;}

		[Ordinal(5)] [RED("appearance")] 		public CName Appearance { get; set;}

		[Ordinal(6)] [RED("type")] 		public CEnum<ECutsceneActorType> Type { get; set;}

		[Ordinal(7)] [RED("finalPosition")] 		public TagList FinalPosition { get; set;}

		[Ordinal(8)] [RED("killMe")] 		public CBool KillMe { get; set;}

		[Ordinal(9)] [RED("useMimic")] 		public CBool UseMimic { get; set;}

		[Ordinal(10)] [RED("animationAtFinalPosition")] 		public CName AnimationAtFinalPosition { get; set;}

		public SCutsceneActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCutsceneActorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}