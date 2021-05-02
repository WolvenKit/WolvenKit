using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Oil : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("currCount")] 		public CInt32 CurrCount { get; set;}

		[Ordinal(2)] [RED("maxCount")] 		public CInt32 MaxCount { get; set;}

		[Ordinal(3)] [RED("sword")] 		public SItemUniqueId Sword { get; set;}

		[Ordinal(4)] [RED("oilAbility")] 		public CName OilAbility { get; set;}

		[Ordinal(5)] [RED("oilItemName")] 		public CName OilItemName { get; set;}

		[Ordinal(6)] [RED("queueTimer")] 		public CInt32 QueueTimer { get; set;}

		public W3Effect_Oil(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}