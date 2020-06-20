using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcBoxCarryParams : CAINpcIdleParams
	{
		[RED("workCarryItemTemplate")] 		public CHandle<CEntityTemplate> WorkCarryItemTemplate { get; set;}

		[RED("workCarryPickupPoint")] 		public CName WorkCarryPickupPoint { get; set;}

		[RED("workCarryDropPoint")] 		public CName WorkCarryDropPoint { get; set;}

		public CAINpcBoxCarryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcBoxCarryParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}