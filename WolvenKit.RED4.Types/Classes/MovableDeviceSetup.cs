using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableDeviceSetup : RedBaseClass
	{
		private CInt32 _numberOfUses;

		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get => GetProperty(ref _numberOfUses);
			set => SetProperty(ref _numberOfUses, value);
		}

		public MovableDeviceSetup()
		{
			_numberOfUses = 1;
		}
	}
}
