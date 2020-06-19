using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScriptedDestroyableComponent : CRigidMeshComponent
	{
		[RED("destroyWay")] 		public CEnum<EDestroyWay> DestroyWay { get; set;}

		[RED("distanceValue")] 		public CFloat DistanceValue { get; set;}

		[RED("destroyTimeDuration")] 		public CFloat DestroyTimeDuration { get; set;}

		[RED("contactDestroyDelay")] 		public CFloat ContactDestroyDelay { get; set;}

		[RED("destroyAtTime")] 		public CFloat DestroyAtTime { get; set;}

		public CScriptedDestroyableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScriptedDestroyableComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}