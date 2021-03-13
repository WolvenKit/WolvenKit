using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSetAdditiveHitFlagDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(2)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(3)] [RED("flag")] 		public CBool Flag { get; set;}

		[Ordinal(4)] [RED("additiveHits")] 		public CBool AdditiveHits { get; set;}

		[Ordinal(5)] [RED("additiveCriticalStates")] 		public CBool AdditiveCriticalStates { get; set;}

		[Ordinal(6)] [RED("overrideOnly")] 		public CBool OverrideOnly { get; set;}

		[Ordinal(7)] [RED("playNormalHitOnCritical")] 		public CBool PlayNormalHitOnCritical { get; set;}

		public BTTaskSetAdditiveHitFlagDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSetAdditiveHitFlagDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}