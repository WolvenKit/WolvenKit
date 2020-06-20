using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVitalSpot : CObject
	{
		[RED("editorLabel")] 		public CName EditorLabel { get; set;}

		[RED("entitySlotName")] 		public CName EntitySlotName { get; set;}

		[RED("normal")] 		public Vector Normal { get; set;}

		[RED("cutDirection")] 		public Vector CutDirection { get; set;}

		[RED("vitalSpotEntry")] 		public CHandle<CJournalPath> VitalSpotEntry { get; set;}

		[RED("hitReactionAnimation")] 		public CName HitReactionAnimation { get; set;}

		[RED("focusPointsCost")] 		public CFloat FocusPointsCost { get; set;}

		[RED("destroyAfterExecution")] 		public CBool DestroyAfterExecution { get; set;}

		[RED("gameplayEffects", 2,0)] 		public CArray<CHandle<IGameplayEffectExecutor>> GameplayEffects { get; set;}

		[RED("enableConditions")] 		public SVitalSpotEnableConditions EnableConditions { get; set;}

		[RED("visualEffect")] 		public CName VisualEffect { get; set;}

		[RED("soundOnFocus")] 		public CString SoundOnFocus { get; set;}

		[RED("soundOffFocus")] 		public CString SoundOffFocus { get; set;}

		public CVitalSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVitalSpot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}