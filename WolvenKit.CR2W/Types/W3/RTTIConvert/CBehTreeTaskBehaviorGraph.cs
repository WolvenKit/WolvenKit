using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskBehaviorGraph : IBehTreeTask
	{
		[Ordinal(1)] [RED("graph")] 		public CEnum<EBehaviorGraph> Graph { get; set;}

		[Ordinal(2)] [RED("forceHighPriority")] 		public CBool ForceHighPriority { get; set;}

		[Ordinal(3)] [RED("res")] 		public CBool Res { get; set;}

		[Ordinal(4)] [RED("graphName")] 		public CName GraphName { get; set;}

		[Ordinal(5)] [RED("combatDataStorage")] 		public CHandle<CHumanAICombatStorage> CombatDataStorage { get; set;}

		public CBehTreeTaskBehaviorGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskBehaviorGraph(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}