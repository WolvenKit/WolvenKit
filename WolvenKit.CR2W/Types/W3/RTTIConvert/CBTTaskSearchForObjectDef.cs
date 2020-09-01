using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSearchForObjectDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("tag")] 		public CBehTreeValCName Tag { get; set;}

		[Ordinal(0)] [RED("("selectRandomObject")] 		public CBool SelectRandomObject { get; set;}

		[Ordinal(0)] [RED("("avoidSelectingPreviousOne")] 		public CBool AvoidSelectingPreviousOne { get; set;}

		[Ordinal(0)] [RED("("dontSelectClosestOneIfPossible")] 		public CBool DontSelectClosestOneIfPossible { get; set;}

		[Ordinal(0)] [RED("("addFactOnLastObject")] 		public CBool AddFactOnLastObject { get; set;}

		[Ordinal(0)] [RED("("setActionTargetOnIsAvailable")] 		public CBool SetActionTargetOnIsAvailable { get; set;}

		[Ordinal(0)] [RED("("cooldown")] 		public CFloat Cooldown { get; set;}

		public CBTTaskSearchForObjectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSearchForObjectDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}