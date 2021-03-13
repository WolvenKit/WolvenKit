using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MeditationClockMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_fxSetBlockMeditation")] 		public CHandle<CScriptedFlashFunction> M_fxSetBlockMeditation { get; set;}

		[Ordinal(2)] [RED("m_fxSetCanMeditate")] 		public CHandle<CScriptedFlashFunction> M_fxSetCanMeditate { get; set;}

		[Ordinal(3)] [RED("m_fxSetBonusMeditationTime")] 		public CHandle<CScriptedFlashFunction> M_fxSetBonusMeditationTime { get; set;}

		[Ordinal(4)] [RED("m_fxSetGeraltBackgroundVisible")] 		public CHandle<CScriptedFlashFunction> M_fxSetGeraltBackgroundVisible { get; set;}

		[Ordinal(5)] [RED("m_fxSet24HRFormat")] 		public CHandle<CScriptedFlashFunction> M_fxSet24HRFormat { get; set;}

		[Ordinal(6)] [RED("canMeditateWait")] 		public CBool CanMeditateWait { get; set;}

		[Ordinal(7)] [RED("isGameTimePaused")] 		public CBool IsGameTimePaused { get; set;}

		[Ordinal(8)] [RED("BONUS_MEDITATION_TIME")] 		public CInt32 BONUS_MEDITATION_TIME { get; set;}

		public CR4MeditationClockMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MeditationClockMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}