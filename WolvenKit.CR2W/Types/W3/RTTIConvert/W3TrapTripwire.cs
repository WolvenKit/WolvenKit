using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapTripwire : W3Trap
	{
		[Ordinal(1)] [RED("eventOnTripped", 2,0)] 		public CArray<CHandle<IPerformableAction>> EventOnTripped { get; set;}

		[Ordinal(2)] [RED("maxUseCount")] 		public CInt32 MaxUseCount { get; set;}

		[Ordinal(3)] [RED("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		public W3TrapTripwire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapTripwire(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}