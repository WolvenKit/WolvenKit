using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerVisuals_BreastSizeController : questICharacterManagerVisuals_NodeSubType
	{
		private CName _bodyGroupName;
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _customizedSize;

		[Ordinal(0)] 
		[RED("bodyGroupName")] 
		public CName BodyGroupName
		{
			get => GetProperty(ref _bodyGroupName);
			set => SetProperty(ref _bodyGroupName, value);
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("customizedSize")] 
		public CBool CustomizedSize
		{
			get => GetProperty(ref _customizedSize);
			set => SetProperty(ref _customizedSize, value);
		}
	}
}
