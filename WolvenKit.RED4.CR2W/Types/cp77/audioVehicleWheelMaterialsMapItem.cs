using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelMaterialsMapItem : CVariable
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

		public audioVehicleWheelMaterialsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
