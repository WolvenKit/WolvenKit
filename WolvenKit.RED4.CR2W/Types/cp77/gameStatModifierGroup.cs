using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierGroup : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _statModifierArray;
		private CInt32 _statModifiersLimit;
		private TweakDBID _statModifiersLimitModifier;
		private CBool _drawBasedOnStatType;

		[Ordinal(0)] 
		[RED("statModifierArray")] 
		public CArray<CHandle<gameStatModifierData>> StatModifierArray
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

		public gameStatModifierGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
