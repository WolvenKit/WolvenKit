using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUniversalRef : ISerializable
	{
		private gameEntityReference _entityReference;
		private CBool _refLocalPlayer;
		private CBool _mainPlayerObject;

		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(1)] 
		[RED("refLocalPlayer")] 
		public CBool RefLocalPlayer
		{
			get => GetProperty(ref _refLocalPlayer);
			set => SetProperty(ref _refLocalPlayer, value);
		}

		[Ordinal(2)] 
		[RED("mainPlayerObject")] 
		public CBool MainPlayerObject
		{
			get => GetProperty(ref _mainPlayerObject);
			set => SetProperty(ref _mainPlayerObject, value);
		}
	}
}
