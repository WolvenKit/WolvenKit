using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCover_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private NodeRef _coverRef;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("coverRef")] 
		public NodeRef CoverRef
		{
			get => GetProperty(ref _coverRef);
			set => SetProperty(ref _coverRef, value);
		}
	}
}
