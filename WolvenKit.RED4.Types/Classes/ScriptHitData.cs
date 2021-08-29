using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptHitData : RedBaseClass
	{
		private CInt32 _animVariation;
		private CInt32 _attackDirection;
		private CInt32 _hitBodyPart;

		[Ordinal(0)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(1)] 
		[RED("attackDirection")] 
		public CInt32 AttackDirection
		{
			get => GetProperty(ref _attackDirection);
			set => SetProperty(ref _attackDirection, value);
		}

		[Ordinal(2)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get => GetProperty(ref _hitBodyPart);
			set => SetProperty(ref _hitBodyPart, value);
		}
	}
}
