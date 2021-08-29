using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatModifierGroup : RedBaseClass
	{
		private CArray<gameStatModifierHandle> _statModifierArray;
		private CInt32 _statModifiersLimit;
		private TweakDBID _statModifiersLimitModifier;
		private CBool _drawBasedOnStatType;

		[Ordinal(0)] 
		[RED("statModifierArray")] 
		public CArray<gameStatModifierHandle> StatModifierArray
		{
			get => GetProperty(ref _statModifierArray);
			set => SetProperty(ref _statModifierArray, value);
		}

		[Ordinal(1)] 
		[RED("statModifiersLimit")] 
		public CInt32 StatModifiersLimit
		{
			get => GetProperty(ref _statModifiersLimit);
			set => SetProperty(ref _statModifiersLimit, value);
		}

		[Ordinal(2)] 
		[RED("statModifiersLimitModifier")] 
		public TweakDBID StatModifiersLimitModifier
		{
			get => GetProperty(ref _statModifiersLimitModifier);
			set => SetProperty(ref _statModifiersLimitModifier, value);
		}

		[Ordinal(3)] 
		[RED("drawBasedOnStatType")] 
		public CBool DrawBasedOnStatType
		{
			get => GetProperty(ref _drawBasedOnStatType);
			set => SetProperty(ref _drawBasedOnStatType, value);
		}
	}
}
