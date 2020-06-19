using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPullReinToHandData : CVariable
	{
		[RED("reinBoneName")] 		public CName ReinBoneName { get; set;}

		[RED("reinContactPoint")] 		public Vector ReinContactPoint { get; set;}

		[RED("handBoneName")] 		public CName HandBoneName { get; set;}

		[RED("handContactPoint")] 		public Vector HandContactPoint { get; set;}

		public SBehaviorConstraintPullReinToHandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintPullReinToHandData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}