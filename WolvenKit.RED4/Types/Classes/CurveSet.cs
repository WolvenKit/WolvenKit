using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurveSet : CResource
	{
		[Ordinal(1)] 
		[RED("curves")] 
		public CArray<CurveSetEntry> Curves
		{
			get => GetPropertyValue<CArray<CurveSetEntry>>();
			set => SetPropertyValue<CArray<CurveSetEntry>>(value);
		}

		public CurveSet()
		{
			Curves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
