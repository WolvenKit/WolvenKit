using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPartyWaypointHandle : CVariable
	{
		[RED("partyMemberName")] 		public CName PartyMemberName { get; set;}

		[RED("entityHandle")] 		public EntityHandle EntityHandle { get; set;}

		[RED("componentName")] 		public CString ComponentName { get; set;}

		public SPartyWaypointHandle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPartyWaypointHandle(cr2w);

	}
}