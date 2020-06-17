using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWanderActionPointSelector : CActionPointSelector
	{
		[RED("categories", 2,0)] 		public CArray<SEncounterActionPointSelectorPair> Categories { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("apTags")] 		public TagList ApTags { get; set;}

		[RED("areaTags")] 		public TagList AreaTags { get; set;}

		[RED("apAreaTag")] 		public CName ApAreaTag { get; set;}

		[RED("chooseClosestAP")] 		public CBool ChooseClosestAP { get; set;}

		public CWanderActionPointSelector(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CWanderActionPointSelector(cr2w);

	}
}