using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSearchForObjectDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(2)] [RED("tag")] 		public CBehTreeValCName Tag { get; set;}

		[Ordinal(3)] [RED("selectRandomObject")] 		public CBool SelectRandomObject { get; set;}

		[Ordinal(4)] [RED("avoidSelectingPreviousOne")] 		public CBool AvoidSelectingPreviousOne { get; set;}

		[Ordinal(5)] [RED("dontSelectClosestOneIfPossible")] 		public CBool DontSelectClosestOneIfPossible { get; set;}

		[Ordinal(6)] [RED("addFactOnLastObject")] 		public CBool AddFactOnLastObject { get; set;}

		[Ordinal(7)] [RED("setActionTargetOnIsAvailable")] 		public CBool SetActionTargetOnIsAvailable { get; set;}

		[Ordinal(8)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		public CBTTaskSearchForObjectDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSearchForObjectDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}