using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraAddAttachmentsResult : ISerializable
	{
		[Ordinal(0)] 
		[RED("array")] 
		public CArray<toolsJiraAttachment> Array
		{
			get => GetPropertyValue<CArray<toolsJiraAttachment>>();
			set => SetPropertyValue<CArray<toolsJiraAttachment>>(value);
		}

		public toolsJiraAddAttachmentsResult()
		{
			Array = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
