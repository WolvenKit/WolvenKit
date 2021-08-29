using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceDismembermentEffector : gameEffector
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _woundType;
		private CBool _isCritical;
		private CBool _skipDeathAnim;
		private CBool _shouldKillNPC;
		private CFloat _dismembermentChance;
		private CHandle<gamedataForceDismembermentEffector_Record> _effectorRecord;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(2)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetProperty(ref _isCritical);
			set => SetProperty(ref _isCritical, value);
		}

		[Ordinal(3)] 
		[RED("skipDeathAnim")] 
		public CBool SkipDeathAnim
		{
			get => GetProperty(ref _skipDeathAnim);
			set => SetProperty(ref _skipDeathAnim, value);
		}

		[Ordinal(4)] 
		[RED("shouldKillNPC")] 
		public CBool ShouldKillNPC
		{
			get => GetProperty(ref _shouldKillNPC);
			set => SetProperty(ref _shouldKillNPC, value);
		}

		[Ordinal(5)] 
		[RED("dismembermentChance")] 
		public CFloat DismembermentChance
		{
			get => GetProperty(ref _dismembermentChance);
			set => SetProperty(ref _dismembermentChance, value);
		}

		[Ordinal(6)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataForceDismembermentEffector_Record> EffectorRecord
		{
			get => GetProperty(ref _effectorRecord);
			set => SetProperty(ref _effectorRecord, value);
		}
	}
}
