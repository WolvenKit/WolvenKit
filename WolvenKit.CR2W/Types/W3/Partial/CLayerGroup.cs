using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CLayerGroup : ISerializable
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("depotPath")] 		public CString DepotPath { get; set;}

		[RED("absolutePath")] 		public CString AbsolutePath { get; set;}

		[RED("isVisibleOnStart")] 		public CBool IsVisibleOnStart { get; set;}

		[RED("systemGroup")] 		public CBool SystemGroup { get; set;}

		[RED("hasEmbeddedLayerInfos")] 		public CBool HasEmbeddedLayerInfos { get; set;}

		[RED("idHash")] 		public CUInt64 IdHash { get; set;}

		public CLayerGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayerGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}