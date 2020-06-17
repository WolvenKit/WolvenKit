using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Bird : CGameplayEntity
	{
		[RED("flyingAppearanceName")] 		public CName FlyingAppearanceName { get; set;}

		[RED("destroyDistance")] 		public CFloat DestroyDistance { get; set;}

		[RED("flyCurves", 2,0)] 		public CArray<CName> FlyCurves { get; set;}

		public W3Bird(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3Bird(cr2w);

	}
}