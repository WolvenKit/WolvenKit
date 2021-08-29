using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		private CName _shapeName;

		[Ordinal(1)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetProperty(ref _shapeName);
			set => SetProperty(ref _shapeName, value);
		}
	}
}
