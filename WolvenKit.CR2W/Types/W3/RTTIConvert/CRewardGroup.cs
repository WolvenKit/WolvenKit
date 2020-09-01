using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRewardGroup : CResource
	{
		[Ordinal(0)] [RED("rewards", 2,0)] 		public CArray<SReward> Rewards { get; set;}

		[Ordinal(0)] [RED("subGroups", 2,0)] 		public CArray<CHandle<CRewardGroup>> SubGroups { get; set;}

		[Ordinal(0)] [RED("isSubGroup")] 		public CBool IsSubGroup { get; set;}

		public CRewardGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRewardGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}