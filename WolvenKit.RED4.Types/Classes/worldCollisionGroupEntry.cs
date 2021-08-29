using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCollisionGroupEntry : RedBaseClass
	{
		private NodeRef _neRef;
		private CBool _reversed;

		[Ordinal(0)] 
		[RED("neRef")] 
		public NodeRef NeRef
		{
			get => GetProperty(ref _neRef);
			set => SetProperty(ref _neRef, value);
		}

		[Ordinal(1)] 
		[RED("Reversed")] 
		public CBool Reversed
		{
			get => GetProperty(ref _reversed);
			set => SetProperty(ref _reversed, value);
		}
	}
}
