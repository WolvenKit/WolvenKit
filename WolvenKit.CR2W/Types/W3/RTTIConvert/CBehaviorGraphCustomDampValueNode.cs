using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphCustomDampValueNode : CBehaviorGraphValueBaseNode
	{
		[RED("type")] 		public CEnum<EBehaviorCustomDampType> Type { get; set;}

		[RED("directionalAcc_MaxAccDiffFromZero")] 		public CFloat DirectionalAcc_MaxAccDiffFromZero { get; set;}

		[RED("directionalAcc_MaxAccDiffToZero")] 		public CFloat DirectionalAcc_MaxAccDiffToZero { get; set;}

		[RED("filterLowPass_RC")] 		public CFloat FilterLowPass_RC { get; set;}

		public CBehaviorGraphCustomDampValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCustomDampValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}