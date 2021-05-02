using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemPlayItemEffect : CFXTrackItem
	{
		[Ordinal(1)] [RED("category")] 		public CName Category { get; set;}

		[Ordinal(2)] [RED("itemName_optional")] 		public CName ItemName_optional { get; set;}

		[Ordinal(3)] [RED("effectName")] 		public CName EffectName { get; set;}

		public CFXTrackItemPlayItemEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}