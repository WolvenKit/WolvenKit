using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_ManageToxicCloud : W3SwitchEvent
	{
		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("operations", 2,0)] 		public CArray<CEnum<EToxicCloudOperation>> Operations { get; set;}

		public W3SE_ManageToxicCloud(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_ManageToxicCloud(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}