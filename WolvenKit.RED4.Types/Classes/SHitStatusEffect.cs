using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SHitStatusEffect : RedBaseClass
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
	}
}
