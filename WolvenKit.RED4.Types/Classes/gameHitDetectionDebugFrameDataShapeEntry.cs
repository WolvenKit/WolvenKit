using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitDetectionDebugFrameDataShapeEntry : RedBaseClass
	{
		private WorldTransform _ansformWS;

		[Ordinal(0)] 
		[RED("ansformWS")] 
		public WorldTransform AnsformWS
		{
			get => GetProperty(ref _ansformWS);
			set => SetProperty(ref _ansformWS, value);
		}
	}
}
