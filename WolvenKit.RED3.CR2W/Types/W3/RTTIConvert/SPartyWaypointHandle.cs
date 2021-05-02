using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPartyWaypointHandle : CVariable
	{
		[Ordinal(1)] [RED("partyMemberName")] 		public CName PartyMemberName { get; set;}

		[Ordinal(2)] [RED("entityHandle")] 		public EntityHandle EntityHandle { get; set;}

		[Ordinal(3)] [RED("componentName")] 		public CString ComponentName { get; set;}

		public SPartyWaypointHandle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPartyWaypointHandle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}