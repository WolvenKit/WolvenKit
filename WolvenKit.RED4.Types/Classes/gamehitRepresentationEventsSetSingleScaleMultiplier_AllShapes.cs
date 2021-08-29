using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes : redEvent
	{
		private Vector4 _scaleMultiplier;

		[Ordinal(0)] 
		[RED("scaleMultiplier")] 
		public Vector4 ScaleMultiplier
		{
			get => GetProperty(ref _scaleMultiplier);
			set => SetProperty(ref _scaleMultiplier, value);
		}
	}
}
