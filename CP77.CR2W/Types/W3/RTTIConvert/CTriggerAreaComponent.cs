using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTriggerAreaComponent : CAreaComponent
	{
		[Ordinal(1)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(2)] [RED("includedChannels")] 		public CEnum<ETriggerChannel> IncludedChannels { get; set;}

		[Ordinal(3)] [RED("excludedChannels")] 		public CEnum<ETriggerChannel> ExcludedChannels { get; set;}

		[Ordinal(4)] [RED("triggerPriority")] 		public CUInt32 TriggerPriority { get; set;}

		[Ordinal(5)] [RED("enableCCD")] 		public CBool EnableCCD { get; set;}

		public CTriggerAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTriggerAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}