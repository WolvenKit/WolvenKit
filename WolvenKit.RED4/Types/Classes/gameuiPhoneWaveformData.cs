using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhoneWaveformData : IScriptable
	{
		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector4> Points
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public gameuiPhoneWaveformData()
		{
			Points = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
