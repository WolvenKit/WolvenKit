using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePredefinedPathDefinition : CBehTreeNodeCustomSteeringDefinition
	{
		[Ordinal(1)] [RED("pathName")] 		public CBehTreeValCName PathName { get; set;}

		[Ordinal(2)] [RED("upThePath")] 		public CBehTreeValBool UpThePath { get; set;}

		[Ordinal(3)] [RED("pathMargin")] 		public CBehTreeValFloat PathMargin { get; set;}

		[Ordinal(4)] [RED("tolerance")] 		public CBehTreeValFloat Tolerance { get; set;}

		[Ordinal(5)] [RED("arrivalDistance")] 		public CBehTreeValFloat ArrivalDistance { get; set;}

		[Ordinal(6)] [RED("useExplorations")] 		public CBehTreeValBool UseExplorations { get; set;}

		public CBehTreeNodePredefinedPathDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePredefinedPathDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}