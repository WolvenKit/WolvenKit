using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcTacticTreeParams : CAISubTreeParameters
	{
		[Ordinal(1)] [RED("specialActions", 2,0)] 		public CArray<CHandle<CAISpecialAction>> SpecialActions { get; set;}

		[Ordinal(2)] [RED("dontUseRunWhileStrafing")] 		public CBool DontUseRunWhileStrafing { get; set;}

		[Ordinal(3)] [RED("allowChangingGuard")] 		public CBool AllowChangingGuard { get; set;}

		public CAINpcTacticTreeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcTacticTreeParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}