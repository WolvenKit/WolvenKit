using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitStatusEffect : CVariable
	{
		private CFloat _stacks;
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get => GetProperty(ref _stacks);
			set => SetProperty(ref _stacks, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public SHitStatusEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
