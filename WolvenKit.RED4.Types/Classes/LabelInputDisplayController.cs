using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LabelInputDisplayController : inkInputDisplayController
	{
		[Ordinal(11)] 
		[RED("inputLabel")] 
		public inkTextWidgetReference InputLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public LabelInputDisplayController()
		{
			InputLabel = new();
		}
	}
}
