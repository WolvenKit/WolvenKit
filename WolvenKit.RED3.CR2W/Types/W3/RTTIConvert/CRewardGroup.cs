using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRewardGroup : CResource
	{
		[Ordinal(1)] [RED("rewards", 2,0)] 		public CArray<SReward> Rewards { get; set;}

		[Ordinal(2)] [RED("subGroups", 2,0)] 		public CArray<CHandle<CRewardGroup>> SubGroups { get; set;}

		[Ordinal(3)] [RED("isSubGroup")] 		public CBool IsSubGroup { get; set;}

		public CRewardGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRewardGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}