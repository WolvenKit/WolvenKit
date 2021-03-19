using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_QuickhackData : CVariable
	{
		private CInt32 _memorycost;
		private CInt32 _baseCost;
		private CFloat _uploadTime;
		private CFloat _duration;
		private CFloat _cooldown;
		private CArray<CHandle<DamageEffectUIEntry>> _attackEffects;
		private CFloat _uploadTimeDiff;
		private CFloat _durationDiff;
		private CFloat _cooldownDiff;

		[Ordinal(0)] 
		[RED("memorycost")] 
		public CInt32 Memorycost
		{
			get => GetProperty(ref _memorycost);
			set => SetProperty(ref _memorycost, value);
		}

		[Ordinal(1)] 
		[RED("baseCost")] 
		public CInt32 BaseCost
		{
			get => GetProperty(ref _baseCost);
			set => SetProperty(ref _baseCost, value);
		}

		[Ordinal(2)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(5)] 
		[RED("attackEffects")] 
		public CArray<CHandle<DamageEffectUIEntry>> AttackEffects
		{
			get => GetProperty(ref _attackEffects);
			set => SetProperty(ref _attackEffects, value);
		}

		[Ordinal(6)] 
		[RED("uploadTimeDiff")] 
		public CFloat UploadTimeDiff
		{
			get => GetProperty(ref _uploadTimeDiff);
			set => SetProperty(ref _uploadTimeDiff, value);
		}

		[Ordinal(7)] 
		[RED("durationDiff")] 
		public CFloat DurationDiff
		{
			get => GetProperty(ref _durationDiff);
			set => SetProperty(ref _durationDiff, value);
		}

		[Ordinal(8)] 
		[RED("cooldownDiff")] 
		public CFloat CooldownDiff
		{
			get => GetProperty(ref _cooldownDiff);
			set => SetProperty(ref _cooldownDiff, value);
		}

		public InventoryTooltipData_QuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
