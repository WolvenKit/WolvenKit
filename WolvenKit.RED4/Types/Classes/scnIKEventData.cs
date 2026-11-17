using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnIKEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("orientation")] 
		public Quaternion Orientation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(1)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(2)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get => GetPropertyValue<animIKTargetRequest>();
			set => SetPropertyValue<animIKTargetRequest>(value);
		}

		public scnIKEventData()
		{
			Orientation = new Quaternion();
			Basic = new scnAnimTargetBasicData();
			ChainName = "ikRightArm";
			Request = new animIKTargetRequest();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
