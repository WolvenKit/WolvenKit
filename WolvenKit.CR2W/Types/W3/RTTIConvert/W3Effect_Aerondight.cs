using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Aerondight : CBaseGameplayEffect
	{
		[RED("m_maxCount")] 		public CInt32 M_maxCount { get; set;}

		[RED("m_currCount")] 		public CInt32 M_currCount { get; set;}

		[RED("m_wasDischarged")] 		public CBool M_wasDischarged { get; set;}

		[RED("m_aerondightTime")] 		public CFloat M_aerondightTime { get; set;}

		[RED("m_attribute")] 		public SAbilityAttributeValue M_attribute { get; set;}

		[RED("m_stacksPerLevel")] 		public SAbilityAttributeValue M_stacksPerLevel { get; set;}

		[RED("m_currChargingEffect")] 		public CName M_currChargingEffect { get; set;}

		[RED("m_aerondightDelay")] 		public CFloat M_aerondightDelay { get; set;}

		[RED("timeOfPause")] 		public GameTime TimeOfPause { get; set;}

		public W3Effect_Aerondight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Aerondight(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}