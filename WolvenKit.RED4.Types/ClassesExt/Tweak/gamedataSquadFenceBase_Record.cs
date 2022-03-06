
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSquadFenceBase_Record
	{
		[RED("paddingInnerFence")]
		[REDProperty(IsIgnored = true)]
		public CFloat PaddingInnerFence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paddingOuterFence")]
		[REDProperty(IsIgnored = true)]
		public CFloat PaddingOuterFence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
