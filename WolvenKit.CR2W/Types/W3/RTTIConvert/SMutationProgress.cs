using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMutationProgress : CVariable
	{
		[RED("redUsed")] 		public CInt32 RedUsed { get; set;}

		[RED("redRequired")] 		public CInt32 RedRequired { get; set;}

		[RED("blueUsed")] 		public CInt32 BlueUsed { get; set;}

		[RED("blueRequired")] 		public CInt32 BlueRequired { get; set;}

		[RED("greenUsed")] 		public CInt32 GreenUsed { get; set;}

		[RED("greenRequired")] 		public CInt32 GreenRequired { get; set;}

		[RED("skillpointsUsed")] 		public CInt32 SkillpointsUsed { get; set;}

		[RED("skillpointsRequired")] 		public CInt32 SkillpointsRequired { get; set;}

		[RED("overallProgress")] 		public CInt32 OverallProgress { get; set;}

		public SMutationProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMutationProgress(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}