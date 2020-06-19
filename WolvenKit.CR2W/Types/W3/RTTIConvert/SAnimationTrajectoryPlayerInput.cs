using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationTrajectoryPlayerInput : CVariable
	{
		[RED("localToWorld")] 		public CMatrix LocalToWorld { get; set;}

		[RED("pointWS")] 		public Vector PointWS { get; set;}

		[RED("directionWS")] 		public Vector DirectionWS { get; set;}

		[RED("tagId")] 		public CName TagId { get; set;}

		[RED("selectorType")] 		public CEnum<EAnimationTrajectorySelectorType> SelectorType { get; set;}

		[RED("proxySyncType")] 		public CEnum<EActionMoveAnimationSyncType> ProxySyncType { get; set;}

		[RED("proxy")] 		public CHandle<CActionMoveAnimationProxy> Proxy { get; set;}

		public SAnimationTrajectoryPlayerInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationTrajectoryPlayerInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}