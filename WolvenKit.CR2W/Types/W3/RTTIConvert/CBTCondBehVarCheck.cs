using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondBehVarCheck : IBehTreeTask
	{
		[RED("behVarName")] 		public CName BehVarName { get; set;}

		[RED("behVarValue")] 		public CInt32 BehVarValue { get; set;}

		[RED("compareOperation")] 		public CEnum<ECompareOp> CompareOperation { get; set;}

		public CBTCondBehVarCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondBehVarCheck(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}