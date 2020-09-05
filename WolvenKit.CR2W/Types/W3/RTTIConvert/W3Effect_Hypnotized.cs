using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Hypnotized : W3CriticalEffect
	{
		[Ordinal(1)] [RED("customCameraStackIndex")] 		public CInt32 CustomCameraStackIndex { get; set;}

		[Ordinal(2)] [RED("envID")] 		public CInt32 EnvID { get; set;}

		[Ordinal(3)] [RED("fxEntity")] 		public CHandle<CEntity> FxEntity { get; set;}

		[Ordinal(4)] [RED("gameplayVisibilityFlag")] 		public CBool GameplayVisibilityFlag { get; set;}

		public W3Effect_Hypnotized(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Hypnotized(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}