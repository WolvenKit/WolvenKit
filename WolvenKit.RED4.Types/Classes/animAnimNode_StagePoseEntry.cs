using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputName")] 
		public CName InputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("parentInput")] 
		public animPoseLink ParentInput
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_StagePoseEntry()
		{
			Id = 4294967295;
			ParentInput = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
