using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redTaskNameMessage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("uniqueName")] 
		public CName UniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public redTaskNameMessage()
		{
			Id = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
