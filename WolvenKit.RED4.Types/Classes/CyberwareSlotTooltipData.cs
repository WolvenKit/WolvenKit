using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareSlotTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public CyberwareSlotTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
