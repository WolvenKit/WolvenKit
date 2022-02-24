using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		[Ordinal(35)] 
		[RED("colorIndex")] 
		public CInt8 ColorIndex
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}
	}
}
