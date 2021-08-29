using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleWheelMaterialsMapItem : RedBaseClass
	{
		private CName _name;
		private CFloat _audioMaterialCoeff;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("audioMaterialCoeff")] 
		public CFloat AudioMaterialCoeff
		{
			get => GetProperty(ref _audioMaterialCoeff);
			set => SetProperty(ref _audioMaterialCoeff, value);
		}
	}
}
