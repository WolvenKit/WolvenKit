using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScriptedDestroyableComponent : CRigidMeshComponent
	{
		[Ordinal(1)] [RED("destroyWay")] 		public CEnum<EDestroyWay> DestroyWay { get; set;}

		[Ordinal(2)] [RED("distanceValue")] 		public CFloat DistanceValue { get; set;}

		[Ordinal(3)] [RED("destroyTimeDuration")] 		public CFloat DestroyTimeDuration { get; set;}

		[Ordinal(4)] [RED("contactDestroyDelay")] 		public CFloat ContactDestroyDelay { get; set;}

		[Ordinal(5)] [RED("destroyAtTime")] 		public CFloat DestroyAtTime { get; set;}

		[Ordinal(6)] [RED("m_state")] 		public CEnum<EScriptedDetroyableComponentState> M_state { get; set;}

		[Ordinal(7)] [RED("entryTime")] 		public CFloat EntryTime { get; set;}

		[Ordinal(8)] [RED("timerInterval")] 		public CFloat TimerInterval { get; set;}

		public CScriptedDestroyableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScriptedDestroyableComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}