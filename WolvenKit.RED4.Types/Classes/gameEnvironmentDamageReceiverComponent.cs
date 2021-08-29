using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEnvironmentDamageReceiverComponent : entIPlacedComponent
	{
		private CFloat _cooldown;
		private CArray<CHandle<gameEnvironmentDamageReceiverShape>> _shapes;

		[Ordinal(5)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<gameEnvironmentDamageReceiverShape>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}
	}
}
