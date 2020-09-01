using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTManageIsPlayerFollower : IBehTreeTask
	{
		[Ordinal(0)] [RED("("targetTagCondition")] 		public CName TargetTagCondition { get; set;}

		[Ordinal(0)] [RED("("overrideForThisTask")] 		public CBool OverrideForThisTask { get; set;}

		[Ordinal(0)] [RED("("disable")] 		public CBool Disable { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("targetTagCompare")] 		public CName TargetTagCompare { get; set;}

		public CBTManageIsPlayerFollower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTManageIsPlayerFollower(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}