using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeSlotData : animAnimFeature
	{
		private CInt32 _attackType;
		private CInt32 _comboNumber;
		private CFloat _startupDuration;
		private CFloat _activeDuration;
		private CFloat _recoverDuration;
		private CFloat _activeHitDuration;
		private CFloat _recoverHitDuration;

		[Ordinal(0)] 
		[RED("attackType")] 
		public CInt32 AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(1)] 
		[RED("comboNumber")] 
		public CInt32 ComboNumber
		{
			get => GetProperty(ref _comboNumber);
			set => SetProperty(ref _comboNumber, value);
		}

		[Ordinal(2)] 
		[RED("startupDuration")] 
		public CFloat StartupDuration
		{
			get => GetProperty(ref _startupDuration);
			set => SetProperty(ref _startupDuration, value);
		}

		[Ordinal(3)] 
		[RED("activeDuration")] 
		public CFloat ActiveDuration
		{
			get => GetProperty(ref _activeDuration);
			set => SetProperty(ref _activeDuration, value);
		}

		[Ordinal(4)] 
		[RED("recoverDuration")] 
		public CFloat RecoverDuration
		{
			get => GetProperty(ref _recoverDuration);
			set => SetProperty(ref _recoverDuration, value);
		}

		[Ordinal(5)] 
		[RED("activeHitDuration")] 
		public CFloat ActiveHitDuration
		{
			get => GetProperty(ref _activeHitDuration);
			set => SetProperty(ref _activeHitDuration, value);
		}

		[Ordinal(6)] 
		[RED("recoverHitDuration")] 
		public CFloat RecoverHitDuration
		{
			get => GetProperty(ref _recoverHitDuration);
			set => SetProperty(ref _recoverHitDuration, value);
		}

		public animAnimFeature_MeleeSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
