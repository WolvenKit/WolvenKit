
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSquadBackyardBase_Record
	{
		[RED("paddingFrom")]
		[REDProperty(IsIgnored = true)]
		public CFloat PaddingFrom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paddingTo")]
		[REDProperty(IsIgnored = true)]
		public CFloat PaddingTo
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
