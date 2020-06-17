using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMaintainSpeedDef : IBehTreeTaskDefinition
	{
		[RED("moveType")] 		public EMoveType MoveType { get; set;}

		[RED("manageFlySpeed")] 		public CBool ManageFlySpeed { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("speedDecay")] 		public CBool SpeedDecay { get; set;}

		[RED("speedDecayOnDeactivate")] 		public CBool SpeedDecayOnDeactivate { get; set;}

		[RED("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[RED("decayAfter")] 		public CFloat DecayAfter { get; set;}

		public CBTTaskMaintainSpeedDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskMaintainSpeedDef(cr2w);

	}
}