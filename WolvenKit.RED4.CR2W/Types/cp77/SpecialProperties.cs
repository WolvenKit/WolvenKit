using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpecialProperties : CVariable
	{
		private CBool _enemyMarker;
		private CArray<CEnum<ETrap>> _traps;

		[Ordinal(0)] 
		[RED("enemyMarker")] 
		public CBool EnemyMarker
		{
			get => GetProperty(ref _enemyMarker);
			set => SetProperty(ref _enemyMarker, value);
		}

		[Ordinal(1)] 
		[RED("traps")] 
		public CArray<CEnum<ETrap>> Traps
		{
			get => GetProperty(ref _traps);
			set => SetProperty(ref _traps, value);
		}

		public SpecialProperties(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
