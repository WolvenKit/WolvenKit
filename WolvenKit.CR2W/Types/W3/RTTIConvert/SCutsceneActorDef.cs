using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCutsceneActorDef : CVariable
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("tag")] 		public TagList Tag { get; set;}

		[RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[RED("template")] 		public CSoft<CEntityTemplate> Template { get; set;}

		[RED("appearance")] 		public CName Appearance { get; set;}

		[RED("type")] 		public CEnum<ECutsceneActorType> Type { get; set;}

		[RED("finalPosition")] 		public TagList FinalPosition { get; set;}

		[RED("killMe")] 		public CBool KillMe { get; set;}

		[RED("useMimic")] 		public CBool UseMimic { get; set;}

		[RED("animationAtFinalPosition")] 		public CName AnimationAtFinalPosition { get; set;}

		public SCutsceneActorDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCutsceneActorDef(cr2w);

	}
}