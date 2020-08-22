using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MeditationClockMenu : CR4MenuBase
	{
		[RED("m_fxSetBlockMeditation")] 		public CHandle<CScriptedFlashFunction> M_fxSetBlockMeditation { get; set;}

		[RED("m_fxSetCanMeditate")] 		public CHandle<CScriptedFlashFunction> M_fxSetCanMeditate { get; set;}

		[RED("m_fxSetBonusMeditationTime")] 		public CHandle<CScriptedFlashFunction> M_fxSetBonusMeditationTime { get; set;}

		[RED("m_fxSetGeraltBackgroundVisible")] 		public CHandle<CScriptedFlashFunction> M_fxSetGeraltBackgroundVisible { get; set;}

		[RED("m_fxSet24HRFormat")] 		public CHandle<CScriptedFlashFunction> M_fxSet24HRFormat { get; set;}

		[RED("canMeditateWait")] 		public CBool CanMeditateWait { get; set;}

		[RED("isGameTimePaused")] 		public CBool IsGameTimePaused { get; set;}

		[RED("BONUS_MEDITATION_TIME")] 		public CInt32 BONUS_MEDITATION_TIME { get; set;}

		public CR4MeditationClockMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MeditationClockMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}