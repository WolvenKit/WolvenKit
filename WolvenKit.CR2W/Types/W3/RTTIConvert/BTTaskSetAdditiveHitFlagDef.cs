using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSetAdditiveHitFlagDef : IBehTreeTaskDefinition
	{
		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[RED("flag")] 		public CBool Flag { get; set;}

		[RED("additiveHits")] 		public CBool AdditiveHits { get; set;}

		[RED("additiveCriticalStates")] 		public CBool AdditiveCriticalStates { get; set;}

		[RED("overrideOnly")] 		public CBool OverrideOnly { get; set;}

		[RED("playNormalHitOnCritical")] 		public CBool PlayNormalHitOnCritical { get; set;}

		public BTTaskSetAdditiveHitFlagDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSetAdditiveHitFlagDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}