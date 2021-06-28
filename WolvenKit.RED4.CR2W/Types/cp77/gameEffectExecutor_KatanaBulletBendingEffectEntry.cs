using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBendingEffectEntry : CVariable
	{
		private CName _tag;
		private raRef<worldEffect> _effect;
		private CBool _attach;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(2)] 
		[RED("attach")] 
		public CBool Attach
		{
			get => GetProperty(ref _attach);
			set => SetProperty(ref _attach, value);
		}

		public gameEffectExecutor_KatanaBulletBendingEffectEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
