using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveTRGFollowLocomotion : CMoveTRGScript
	{
		[RED("attractor")] 		public CHandle<CNode> Attractor { get; set;}

		[RED("minimumDistance")] 		public CFloat MinimumDistance { get; set;}

		public CMoveTRGFollowLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveTRGFollowLocomotion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}