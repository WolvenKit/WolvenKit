namespace WolvenKit.RED4.Types
{
    public partial class Computer
    {
        [RED("mailsStructure")]
        [OrdinalOverride(Before = 48)]
        public CArray<gamedeviceGenericDataContent> MailsStructure
        {
            get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
            set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
        }
        
        [RED("filesStructure")]
        [OrdinalOverride(Before = 48)]
        public CArray<gamedeviceGenericDataContent> FilesStructure
        {
            get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
            set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
        }
        
        [RED("newsFeed")]
        [OrdinalOverride(Before = 48)]
        public SNewsFeedData NewsFeed
        {
            get => GetPropertyValue<SNewsFeedData>();
            set => SetPropertyValue<SNewsFeedData>(value);
        }
    }
}
