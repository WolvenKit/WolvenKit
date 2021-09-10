using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkOnscreenVOData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CRUID Text
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}
	}
}
