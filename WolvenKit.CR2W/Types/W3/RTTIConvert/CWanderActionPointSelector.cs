using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWanderActionPointSelector : CActionPointSelector
	{
		[Ordinal(1)] [RED("categories", 2,0)] 		public CArray<SEncounterActionPointSelectorPair> Categories { get; set;}

		[Ordinal(2)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(3)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(4)] [RED("apTags")] 		public TagList ApTags { get; set;}

		[Ordinal(5)] [RED("areaTags")] 		public TagList AreaTags { get; set;}

		[Ordinal(6)] [RED("apAreaTag")] 		public CName ApAreaTag { get; set;}

		[Ordinal(7)] [RED("chooseClosestAP")] 		public CBool ChooseClosestAP { get; set;}

		public CWanderActionPointSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWanderActionPointSelector(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}