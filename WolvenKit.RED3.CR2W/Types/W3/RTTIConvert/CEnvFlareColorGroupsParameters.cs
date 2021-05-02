using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvFlareColorGroupsParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("default")] 		public CEnvFlareColorParameters Default { get; set;}

		[Ordinal(3)] [RED("custom0")] 		public CEnvFlareColorParameters Custom0 { get; set;}

		[Ordinal(4)] [RED("custom1")] 		public CEnvFlareColorParameters Custom1 { get; set;}

		[Ordinal(5)] [RED("custom2")] 		public CEnvFlareColorParameters Custom2 { get; set;}

		public CEnvFlareColorGroupsParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvFlareColorGroupsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}