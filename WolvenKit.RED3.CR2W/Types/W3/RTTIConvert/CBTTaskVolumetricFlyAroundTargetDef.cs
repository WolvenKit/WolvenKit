using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricFlyAroundTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(2)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(3)] [RED("flightMaxDuration")] 		public CFloat FlightMaxDuration { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskVolumetricFlyAroundTargetDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricFlyAroundTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}