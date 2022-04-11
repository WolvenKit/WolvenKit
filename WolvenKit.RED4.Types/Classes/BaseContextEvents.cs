using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseContextEvents : InputContextTransitionEvents
	{
		[Ordinal(1)] 
		[RED("slicingFrame")] 
		public CInt32 SlicingFrame
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
