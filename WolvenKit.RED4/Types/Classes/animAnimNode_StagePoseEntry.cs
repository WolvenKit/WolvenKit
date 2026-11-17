using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("inputName")] 
		public CName InputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("parentInput")] 
		public animPoseLink ParentInput
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_StagePoseEntry()
		{
			Id = uint.MaxValue;
			ParentInput = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
