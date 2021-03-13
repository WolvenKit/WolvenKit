using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTManageIsPlayerFollowerDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("targetTagCondition")] 		public CName TargetTagCondition { get; set;}

		[Ordinal(2)] [RED("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[Ordinal(3)] [RED("disable")] 		public CBool Disable { get; set;}

		[Ordinal(4)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("params1")] 		public CHandle<CAIFollowParams> Params1 { get; set;}

		[Ordinal(7)] [RED("params2")] 		public CHandle<CAIMoveAlongPathWithCompanionParams> Params2 { get; set;}

		public CBTManageIsPlayerFollowerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTManageIsPlayerFollowerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}