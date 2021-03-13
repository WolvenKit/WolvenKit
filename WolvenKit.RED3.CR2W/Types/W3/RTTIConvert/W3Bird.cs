using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Bird : CGameplayEntity
	{
		[Ordinal(1)] [RED("flyingAppearanceName")] 		public CName FlyingAppearanceName { get; set;}

		[Ordinal(2)] [RED("destroyDistance")] 		public CFloat DestroyDistance { get; set;}

		[Ordinal(3)] [RED("flyCurves", 2,0)] 		public CArray<CName> FlyCurves { get; set;}

		[Ordinal(4)] [RED("manager")] 		public CHandle<CBirdsManager> Manager { get; set;}

		public W3Bird(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Bird(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}