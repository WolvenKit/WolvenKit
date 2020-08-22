using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTManageIsPlayerFollowerDef : IBehTreeTaskDefinition
	{
		[RED("targetTagCondition")] 		public CName TargetTagCondition { get; set;}

		[RED("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[RED("disable")] 		public CBool Disable { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("params1")] 		public CHandle<CAIFollowParams> Params1 { get; set;}

		[RED("params2")] 		public CHandle<CAIMoveAlongPathWithCompanionParams> Params2 { get; set;}

		public CBTManageIsPlayerFollowerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTManageIsPlayerFollowerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}