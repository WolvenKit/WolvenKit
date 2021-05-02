using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TCrDefinition : CObject
	{
		[Ordinal(1)] [RED("root")] 		public CName Root { get; set;}

		[Ordinal(2)] [RED("indexRoot")] 		public CInt32 IndexRoot { get; set;}

		[Ordinal(3)] [RED("pelvis")] 		public CName Pelvis { get; set;}

		[Ordinal(4)] [RED("indexPelvis")] 		public CInt32 IndexPelvis { get; set;}

		[Ordinal(5)] [RED("torso1")] 		public CName Torso1 { get; set;}

		[Ordinal(6)] [RED("indexTorso1")] 		public CInt32 IndexTorso1 { get; set;}

		[Ordinal(7)] [RED("torso2")] 		public CName Torso2 { get; set;}

		[Ordinal(8)] [RED("indexTorso2")] 		public CInt32 IndexTorso2 { get; set;}

		[Ordinal(9)] [RED("torso3")] 		public CName Torso3 { get; set;}

		[Ordinal(10)] [RED("indexTorso3")] 		public CInt32 IndexTorso3 { get; set;}

		[Ordinal(11)] [RED("neck")] 		public CName Neck { get; set;}

		[Ordinal(12)] [RED("indexNeck")] 		public CInt32 IndexNeck { get; set;}

		[Ordinal(13)] [RED("head")] 		public CName Head { get; set;}

		[Ordinal(14)] [RED("indexHead")] 		public CInt32 IndexHead { get; set;}

		[Ordinal(15)] [RED("shoulderL")] 		public CName ShoulderL { get; set;}

		[Ordinal(16)] [RED("indexShoulderL")] 		public CInt32 IndexShoulderL { get; set;}

		[Ordinal(17)] [RED("bicepL")] 		public CName BicepL { get; set;}

		[Ordinal(18)] [RED("indexBicepL")] 		public CInt32 IndexBicepL { get; set;}

		[Ordinal(19)] [RED("forearmL")] 		public CName ForearmL { get; set;}

		[Ordinal(20)] [RED("indexForearmL")] 		public CInt32 IndexForearmL { get; set;}

		[Ordinal(21)] [RED("handL")] 		public CName HandL { get; set;}

		[Ordinal(22)] [RED("indexHandL")] 		public CInt32 IndexHandL { get; set;}

		[Ordinal(23)] [RED("weaponL")] 		public CName WeaponL { get; set;}

		[Ordinal(24)] [RED("indexWeaponL")] 		public CInt32 IndexWeaponL { get; set;}

		[Ordinal(25)] [RED("shoulderR")] 		public CName ShoulderR { get; set;}

		[Ordinal(26)] [RED("indexShoulderR")] 		public CInt32 IndexShoulderR { get; set;}

		[Ordinal(27)] [RED("bicepR")] 		public CName BicepR { get; set;}

		[Ordinal(28)] [RED("indexBicepR")] 		public CInt32 IndexBicepR { get; set;}

		[Ordinal(29)] [RED("forearmR")] 		public CName ForearmR { get; set;}

		[Ordinal(30)] [RED("indexForearmR")] 		public CInt32 IndexForearmR { get; set;}

		[Ordinal(31)] [RED("handR")] 		public CName HandR { get; set;}

		[Ordinal(32)] [RED("indexHandR")] 		public CInt32 IndexHandR { get; set;}

		[Ordinal(33)] [RED("weaponR")] 		public CName WeaponR { get; set;}

		[Ordinal(34)] [RED("indexWeaponR")] 		public CInt32 IndexWeaponR { get; set;}

		[Ordinal(35)] [RED("thighL")] 		public CName ThighL { get; set;}

		[Ordinal(36)] [RED("indexThighL")] 		public CInt32 IndexThighL { get; set;}

		[Ordinal(37)] [RED("shinL")] 		public CName ShinL { get; set;}

		[Ordinal(38)] [RED("indexShinL")] 		public CInt32 IndexShinL { get; set;}

		[Ordinal(39)] [RED("footL")] 		public CName FootL { get; set;}

		[Ordinal(40)] [RED("indexFootL")] 		public CInt32 IndexFootL { get; set;}

		[Ordinal(41)] [RED("toeL")] 		public CName ToeL { get; set;}

		[Ordinal(42)] [RED("indexToeL")] 		public CInt32 IndexToeL { get; set;}

		[Ordinal(43)] [RED("thighR")] 		public CName ThighR { get; set;}

		[Ordinal(44)] [RED("indexThighR")] 		public CInt32 IndexThighR { get; set;}

		[Ordinal(45)] [RED("shinR")] 		public CName ShinR { get; set;}

		[Ordinal(46)] [RED("indexShinR")] 		public CInt32 IndexShinR { get; set;}

		[Ordinal(47)] [RED("footR")] 		public CName FootR { get; set;}

		[Ordinal(48)] [RED("indexFootR")] 		public CInt32 IndexFootR { get; set;}

		[Ordinal(49)] [RED("toeR")] 		public CName ToeR { get; set;}

		[Ordinal(50)] [RED("indexToeR")] 		public CInt32 IndexToeR { get; set;}

		[Ordinal(51)] [RED("pelvisUpDir")] 		public CEnum<EAxis> PelvisUpDir { get; set;}

		[Ordinal(52)] [RED("torso1UpDir")] 		public CEnum<EAxis> Torso1UpDir { get; set;}

		[Ordinal(53)] [RED("torso2UpDir")] 		public CEnum<EAxis> Torso2UpDir { get; set;}

		[Ordinal(54)] [RED("torso3UpDir")] 		public CEnum<EAxis> Torso3UpDir { get; set;}

		public TCrDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TCrDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}