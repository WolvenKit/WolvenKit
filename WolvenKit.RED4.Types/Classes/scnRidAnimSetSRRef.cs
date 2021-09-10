using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidAnimSetSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnSRRefId> Animations
		{
			get => GetPropertyValue<CArray<scnSRRefId>>();
			set => SetPropertyValue<CArray<scnSRRefId>>(value);
		}

		public scnRidAnimSetSRRef()
		{
			Animations = new();
		}
	}
}
