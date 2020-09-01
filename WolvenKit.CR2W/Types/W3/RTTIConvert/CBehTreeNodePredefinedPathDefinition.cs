using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodePredefinedPathDefinition : CBehTreeNodeCustomSteeringDefinition
	{
		[Ordinal(0)] [RED("pathName")] 		public CBehTreeValCName PathName { get; set;}

		[Ordinal(0)] [RED("upThePath")] 		public CBehTreeValBool UpThePath { get; set;}

		[Ordinal(0)] [RED("pathMargin")] 		public CBehTreeValFloat PathMargin { get; set;}

		[Ordinal(0)] [RED("tolerance")] 		public CBehTreeValFloat Tolerance { get; set;}

		[Ordinal(0)] [RED("arrivalDistance")] 		public CBehTreeValFloat ArrivalDistance { get; set;}

		[Ordinal(0)] [RED("useExplorations")] 		public CBehTreeValBool UseExplorations { get; set;}

		public CBehTreeNodePredefinedPathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodePredefinedPathDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}