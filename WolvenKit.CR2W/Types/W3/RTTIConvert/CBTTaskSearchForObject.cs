using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSearchForObject : IBehTreeTask
	{
		[RED("range")] 		public CFloat Range { get; set;}

		[RED("tag")] 		public CName Tag { get; set;}

		[RED("selectRandomObject")] 		public CBool SelectRandomObject { get; set;}

		[RED("avoidSelectingPreviousOne")] 		public CBool AvoidSelectingPreviousOne { get; set;}

		[RED("dontSelectClosestOneIfPossible")] 		public CBool DontSelectClosestOneIfPossible { get; set;}

		[RED("addFactOnLastObject")] 		public CBool AddFactOnLastObject { get; set;}

		[RED("setActionTargetOnIsAvailable")] 		public CBool SetActionTargetOnIsAvailable { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("selectedObject")] 		public CHandle<CNode> SelectedObject { get; set;}

		[RED("previouslySelectedObject")] 		public CHandle<CGameplayEntity> PreviouslySelectedObject { get; set;}

		[RED("searchTimeStamp")] 		public CFloat SearchTimeStamp { get; set;}

		public CBTTaskSearchForObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSearchForObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}