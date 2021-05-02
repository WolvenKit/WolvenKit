using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageSplashEffect : IBehTreeTask
	{
		[Ordinal(1)] [RED("m_SplashEntityTemplate")] 		public CHandle<CEntityTemplate> M_SplashEntityTemplate { get; set;}

		[Ordinal(2)] [RED("m_PreviousDistanceFromSurface")] 		public CFloat M_PreviousDistanceFromSurface { get; set;}

		[Ordinal(3)] [RED("m_CrossedOnce")] 		public CBool M_CrossedOnce { get; set;}

		[Ordinal(4)] [RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public BTTaskManageSplashEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageSplashEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}