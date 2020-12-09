using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathStateDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("destroyAfterAnimDelay")] 		public CBehTreeValFloat DestroyAfterAnimDelay { get; set;}

		[Ordinal(2)] [RED("fxName")] 		public CBehTreeValCName FxName { get; set;}

		[Ordinal(3)] [RED("setAppearanceTo")] 		public CBehTreeValCName SetAppearanceTo { get; set;}

		[Ordinal(4)] [RED("changeAppearanceAfter")] 		public CBehTreeValFloat ChangeAppearanceAfter { get; set;}

		[Ordinal(5)] [RED("createReactionEvent")] 		public CBehTreeValCName CreateReactionEvent { get; set;}

		public CBehTreeTaskDeathStateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskDeathStateDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}