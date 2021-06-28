using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBending : gameEffectExecutor_Scripted
	{
		private CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> _effects;

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		public gameEffectExecutor_KatanaBulletBending(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
