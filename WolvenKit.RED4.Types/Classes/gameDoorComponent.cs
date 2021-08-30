using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDoorComponent : entIComponent
	{
		private CBool _interactible;
		private CBool _automatic;
		private CBool _physical;
		private CFloat _autoOpeningSpeed;

		[Ordinal(3)] 
		[RED("interactible")] 
		public CBool Interactible
		{
			get => GetProperty(ref _interactible);
			set => SetProperty(ref _interactible, value);
		}

		[Ordinal(4)] 
		[RED("automatic")] 
		public CBool Automatic
		{
			get => GetProperty(ref _automatic);
			set => SetProperty(ref _automatic, value);
		}

		[Ordinal(5)] 
		[RED("physical")] 
		public CBool Physical
		{
			get => GetProperty(ref _physical);
			set => SetProperty(ref _physical, value);
		}

		[Ordinal(6)] 
		[RED("autoOpeningSpeed")] 
		public CFloat AutoOpeningSpeed
		{
			get => GetProperty(ref _autoOpeningSpeed);
			set => SetProperty(ref _autoOpeningSpeed, value);
		}

		public gameDoorComponent()
		{
			_interactible = true;
			_autoOpeningSpeed = 1.000000F;
		}
	}
}
