using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_SlashEffect_Entry : RedBaseClass
	{
		private CInt32 _attackNumber;
		private CArray<CName> _effectNames;

		[Ordinal(0)] 
		[RED("attackNumber")] 
		public CInt32 AttackNumber
		{
			get => GetProperty(ref _attackNumber);
			set => SetProperty(ref _attackNumber, value);
		}

		[Ordinal(1)] 
		[RED("effectNames")] 
		public CArray<CName> EffectNames
		{
			get => GetProperty(ref _effectNames);
			set => SetProperty(ref _effectNames, value);
		}
	}
}
