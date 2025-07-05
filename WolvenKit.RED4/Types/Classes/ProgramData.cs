using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgramData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("commandLists")] 
		public CArray<CArray<ElementData>> CommandLists
		{
			get => GetPropertyValue<CArray<CArray<ElementData>>>();
			set => SetPropertyValue<CArray<CArray<ElementData>>>(value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CEnum<ProgramEffect>> Effects
		{
			get => GetPropertyValue<CArray<CEnum<ProgramEffect>>>();
			set => SetPropertyValue<CArray<CEnum<ProgramEffect>>>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ProgramType> Type
		{
			get => GetPropertyValue<CEnum<ProgramType>>();
			set => SetPropertyValue<CEnum<ProgramType>>(value);
		}

		[Ordinal(4)] 
		[RED("localizationKey")] 
		public CString LocalizationKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("startAsUnknown")] 
		public CBool StartAsUnknown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("wasCompleted")] 
		public CBool WasCompleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProgramData()
		{
			CommandLists = new();
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
