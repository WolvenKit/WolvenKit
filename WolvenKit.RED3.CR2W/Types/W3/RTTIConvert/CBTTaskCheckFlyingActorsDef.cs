using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckFlyingActorsDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("minFlyingActors")] 		public CInt32 MinFlyingActors { get; set;}

		[Ordinal(2)] [RED("maxFlyingActors")] 		public CInt32 MaxFlyingActors { get; set;}

		[Ordinal(3)] [RED("flyingCheckType")] 		public CEnum<EFlyingCheck> FlyingCheckType { get; set;}

		[Ordinal(4)] [RED("ifNot")] 		public CBool IfNot { get; set;}

		public CBTTaskCheckFlyingActorsDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}