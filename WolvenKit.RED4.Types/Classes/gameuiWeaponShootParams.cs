using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWeaponShootParams : RedBaseClass
	{
		private Vector4 _fromWorldPosition;
		private Vector4 _forward;

		[Ordinal(0)] 
		[RED("fromWorldPosition")] 
		public Vector4 FromWorldPosition
		{
			get => GetProperty(ref _fromWorldPosition);
			set => SetProperty(ref _fromWorldPosition, value);
		}

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetProperty(ref _forward);
			set => SetProperty(ref _forward, value);
		}
	}
}
