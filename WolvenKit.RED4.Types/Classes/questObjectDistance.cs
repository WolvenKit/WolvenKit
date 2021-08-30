using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectDistance : questIDistance
	{
		private CBool _isPlayer;
		private gameEntityReference _nodeRef1;
		private gameEntityReference _nodeRef2;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(1)] 
		[RED("nodeRef1")] 
		public gameEntityReference NodeRef1
		{
			get => GetProperty(ref _nodeRef1);
			set => SetProperty(ref _nodeRef1, value);
		}

		[Ordinal(2)] 
		[RED("nodeRef2")] 
		public gameEntityReference NodeRef2
		{
			get => GetProperty(ref _nodeRef2);
			set => SetProperty(ref _nodeRef2, value);
		}

		public questObjectDistance()
		{
			_isPlayer = true;
		}
	}
}
