using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityTemplateColoringEntry : CVariable
	{
		[RED("appearance")] 		public CName Appearance { get; set;}

		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("colorShift1")] 		public CColorShift ColorShift1 { get; set;}

		[RED("colorShift2")] 		public CColorShift ColorShift2 { get; set;}

		public SEntityTemplateColoringEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEntityTemplateColoringEntry(cr2w);

	}
}