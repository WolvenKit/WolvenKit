
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttachmentSlot_Record
	{
		[RED("customOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 CustomOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("entitySlotName")]
		[REDProperty(IsIgnored = true)]
		public CString EntitySlotName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("tagsForActiveItemCycling")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> TagsForActiveItemCycling
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
