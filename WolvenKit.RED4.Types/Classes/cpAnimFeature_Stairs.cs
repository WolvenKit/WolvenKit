using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpAnimFeature_Stairs : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("onOff")] 
		public CBool OnOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
