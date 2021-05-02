using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcDettlaffMinionParryAction : CAINpcDefenseAction
	{
		[Ordinal(1)] [RED("activationTimeLimitBonusHeavy")] 		public CFloat ActivationTimeLimitBonusHeavy { get; set;}

		[Ordinal(2)] [RED("activationTimeLimitBonusLight")] 		public CFloat ActivationTimeLimitBonusLight { get; set;}

		public CAINpcDettlaffMinionParryAction(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcDettlaffMinionParryAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}