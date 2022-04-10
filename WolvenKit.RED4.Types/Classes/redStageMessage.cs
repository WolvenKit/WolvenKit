using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redStageMessage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(3)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public redStageMessage()
		{
			Parent = 4294967295;
			Names = new();
			Ids = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
