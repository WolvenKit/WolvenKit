using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIStorageReactionData : IScriptable
	{
		[Ordinal(1)] [RED("TAUNTS_TO_BE_ALARMED")] 		public CInt32 TAUNTS_TO_BE_ALARMED { get; set;}

		[Ordinal(2)] [RED("alarmedTimeStamp")] 		public CFloat AlarmedTimeStamp { get; set;}

		[Ordinal(3)] [RED("tauntCounter")] 		public CInt32 TauntCounter { get; set;}

		[Ordinal(4)] [RED("lastTauntTimeStamp")] 		public CFloat LastTauntTimeStamp { get; set;}

		[Ordinal(5)] [RED("temporaryHostileActors", 2,0)] 		public CArray<CHandle<CActor>> TemporaryHostileActors { get; set;}

		public CAIStorageReactionData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIStorageReactionData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}