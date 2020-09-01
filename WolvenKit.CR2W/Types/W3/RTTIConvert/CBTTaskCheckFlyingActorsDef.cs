using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckFlyingActorsDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("("minFlyingActors")] 		public CInt32 MinFlyingActors { get; set;}

		[Ordinal(2)] [RED("("maxFlyingActors")] 		public CInt32 MaxFlyingActors { get; set;}

		[Ordinal(3)] [RED("("flyingCheckType")] 		public CEnum<EFlyingCheck> FlyingCheckType { get; set;}

		[Ordinal(4)] [RED("("ifNot")] 		public CBool IfNot { get; set;}

		public CBTTaskCheckFlyingActorsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckFlyingActorsDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}