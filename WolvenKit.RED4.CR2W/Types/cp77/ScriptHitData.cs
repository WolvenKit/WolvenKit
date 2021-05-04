using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptHitData : CVariable
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

		public ScriptHitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
