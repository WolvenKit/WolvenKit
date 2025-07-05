using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCorrectivePoseEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("comparePose")] 
		public CName ComparePose
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("correctivePose")] 
		public CName CorrectivePose
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("jointsToCompare")] 
		public CArray<CName> JointsToCompare
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animCorrectivePoseEntry()
		{
			JointsToCompare = new();
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
