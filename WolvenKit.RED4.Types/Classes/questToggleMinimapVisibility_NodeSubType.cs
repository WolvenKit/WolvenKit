using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleMinimapVisibility_NodeSubType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questToggleMinimapVisibility_NodeSubType()
		{
			EntityReference = new() { Names = new() };
			Show = true;
		}
	}
}
