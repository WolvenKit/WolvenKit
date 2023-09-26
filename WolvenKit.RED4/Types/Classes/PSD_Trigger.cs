using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSD_Trigger : gameObject
	{
		[Ordinal(36)] 
		[RED("ref")] 
		public NodeRef Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(37)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PSD_Trigger()
		{
			ClassName = "PSD_DetectorPS";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
