using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDettlaffDashDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("OpenForAard")] 		public CBool OpenForAard { get; set;}

		[Ordinal(2)] [RED("shouldCheckVisibility")] 		public CBool ShouldCheckVisibility { get; set;}

		[Ordinal(3)] [RED("shouldSignalGameplayEvent")] 		public CBool ShouldSignalGameplayEvent { get; set;}

		public CBTTaskDettlaffDashDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDettlaffDashDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}