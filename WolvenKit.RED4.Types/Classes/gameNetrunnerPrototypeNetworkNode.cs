using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		private CInt8 _colorIndex;

		[Ordinal(40)] 
		[RED("colorIndex")] 
		public CInt8 ColorIndex
		{
			get => GetProperty(ref _colorIndex);
			set => SetProperty(ref _colorIndex, value);
		}
	}
}
