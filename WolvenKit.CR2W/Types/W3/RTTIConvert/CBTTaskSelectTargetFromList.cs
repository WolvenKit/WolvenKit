using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSelectTargetFromList : IBehTreeTask
	{
		[Ordinal(1)] [RED("targetList", 2,0)] 		public CArray<CName> TargetList { get; set;}

		[Ordinal(2)] [RED("currentTargetIndex")] 		public CInt32 CurrentTargetIndex { get; set;}

		[Ordinal(3)] [RED("currentTarget")] 		public CHandle<CNode> CurrentTarget { get; set;}

		[Ordinal(4)] [RED("targetToSelect")] 		public CHandle<CNode> TargetToSelect { get; set;}

		public CBTTaskSelectTargetFromList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSelectTargetFromList(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}