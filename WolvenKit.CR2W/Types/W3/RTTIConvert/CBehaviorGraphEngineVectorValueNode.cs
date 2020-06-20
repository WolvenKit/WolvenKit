using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEngineVectorValueNode : CBehaviorGraphVectorVariableNode
	{
		[RED("engineValueType")] 		public CEnum<EBehaviorEngineVectorValueType> EngineValueType { get; set;}

		[RED("manualControl")] 		public CBool ManualControl { get; set;}

		[RED("cachedVectorVariable")] 		public CPtr<CBehaviorVectorVariable> CachedVectorVariable { get; set;}

		public CBehaviorGraphEngineVectorValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphEngineVectorValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}