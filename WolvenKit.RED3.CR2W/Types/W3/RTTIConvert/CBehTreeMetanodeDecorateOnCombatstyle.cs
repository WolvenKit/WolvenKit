using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeMetanodeDecorateOnCombatstyle : IBehTreeNodeConditionalBaseNodeDefinition
	{
		[Ordinal(1)] [RED("behaviorGraphVarName")] 		public CName BehaviorGraphVarName { get; set;}

		[Ordinal(2)] [RED("combatStyleId")] 		public CInt32 CombatStyleId { get; set;}

		public CBehTreeMetanodeDecorateOnCombatstyle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeMetanodeDecorateOnCombatstyle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}