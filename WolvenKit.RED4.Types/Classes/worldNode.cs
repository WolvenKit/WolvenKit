using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNode : ISerializable
	{
		private CBool _isVisibleInGame;
		private CBool _isHostOnly;

		[Ordinal(2)] 
		[RED("isVisibleInGame")] 
		public CBool IsVisibleInGame
		{
			get => GetProperty(ref _isVisibleInGame);
			set => SetProperty(ref _isVisibleInGame, value);
		}

		[Ordinal(3)] 
		[RED("isHostOnly")] 
		public CBool IsHostOnly
		{
			get => GetProperty(ref _isHostOnly);
			set => SetProperty(ref _isHostOnly, value);
		}
	}
}
