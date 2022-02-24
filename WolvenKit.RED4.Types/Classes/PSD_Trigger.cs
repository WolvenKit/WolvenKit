using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSD_Trigger : gameObject
	{
		[Ordinal(35)] 
		[RED("ref")] 
		public NodeRef Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(36)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PSD_Trigger()
		{
			ClassName = "PSD_DetectorPS";
		}
	}
}
