using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAHDAutoLootFeatureManager : CObject
	{
		[Ordinal(1)] [RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[Ordinal(2)] [RED("AutoLootConfig")] 		public CHandle<CAHDAutoLootConfig> AutoLootConfig { get; set;}

		[Ordinal(3)] [RED("AutoLootNotificationManager")] 		public CHandle<CAHDAutoLootNotificationManager> AutoLootNotificationManager { get; set;}

		[Ordinal(4)] [RED("UserSettings")] 		public CHandle<CInGameConfigWrapper> UserSettings { get; set;}

		[Ordinal(5)] [RED("AHDAL_TRUE_AUTOLOOT_MODE")] 		public CString AHDAL_TRUE_AUTOLOOT_MODE { get; set;}

		[Ordinal(6)] [RED("AHDAL_RADIUS_LOOT")] 		public CString AHDAL_RADIUS_LOOT { get; set;}

		public CAHDAutoLootFeatureManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAHDAutoLootFeatureManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}