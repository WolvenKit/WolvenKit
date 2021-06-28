using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect_Entry : CVariable
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

		public EffectExecutor_SlashEffect_Entry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
