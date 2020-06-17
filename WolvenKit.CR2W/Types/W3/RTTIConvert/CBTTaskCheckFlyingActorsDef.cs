using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckFlyingActorsDef : IBehTreeTaskDefinition
	{
		[RED("minFlyingActors")] 		public CInt32 MinFlyingActors { get; set;}

		[RED("maxFlyingActors")] 		public CInt32 MaxFlyingActors { get; set;}

		[RED("flyingCheckType")] 		public EFlyingCheck FlyingCheckType { get; set;}

		[RED("ifNot")] 		public CBool IfNot { get; set;}

		public CBTTaskCheckFlyingActorsDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskCheckFlyingActorsDef(cr2w);

	}
}