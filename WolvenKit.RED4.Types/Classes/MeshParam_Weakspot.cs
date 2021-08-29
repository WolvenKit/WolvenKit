using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeshParam_Weakspot : animAnimFeature
	{
		private CInt32 _hidden;

		[Ordinal(0)] 
		[RED("hidden")] 
		public CInt32 Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}
	}
}
