using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhoneWaveformData : IScriptable
	{
		private CArray<Vector4> _points;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector4> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}
	}
}
