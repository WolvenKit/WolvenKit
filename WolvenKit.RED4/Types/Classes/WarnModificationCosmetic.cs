using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WarnModificationCosmetic : inkButtonController
	{
		[Ordinal(13)] 
		[RED("modifiedFlag")] 
		public inkWidgetReference ModifiedFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("isModified")] 
		public CBool IsModified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WarnModificationCosmetic()
		{
			ModifiedFlag = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
