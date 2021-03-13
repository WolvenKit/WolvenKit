using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Aerondight : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("m_maxCount")] 		public CInt32 M_maxCount { get; set;}

		[Ordinal(2)] [RED("m_currCount")] 		public CInt32 M_currCount { get; set;}

		[Ordinal(3)] [RED("m_wasDischarged")] 		public CBool M_wasDischarged { get; set;}

		[Ordinal(4)] [RED("m_aerondightTime")] 		public CFloat M_aerondightTime { get; set;}

		[Ordinal(5)] [RED("m_attribute")] 		public SAbilityAttributeValue M_attribute { get; set;}

		[Ordinal(6)] [RED("m_stacksPerLevel")] 		public SAbilityAttributeValue M_stacksPerLevel { get; set;}

		[Ordinal(7)] [RED("m_currChargingEffect")] 		public CName M_currChargingEffect { get; set;}

		[Ordinal(8)] [RED("m_aerondightDelay")] 		public CFloat M_aerondightDelay { get; set;}

		[Ordinal(9)] [RED("timeOfPause")] 		public GameTime TimeOfPause { get; set;}

		public W3Effect_Aerondight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Aerondight(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}