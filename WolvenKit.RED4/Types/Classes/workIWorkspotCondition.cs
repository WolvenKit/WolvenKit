using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class workIWorkspotCondition : ISerializable
	{
		[Ordinal(0)] 
		[RED("expectedResult")] 
		public CEnum<workWorkspotLogic> ExpectedResult
		{
			get => GetPropertyValue<CEnum<workWorkspotLogic>>();
			set => SetPropertyValue<CEnum<workWorkspotLogic>>(value);
		}

		[Ordinal(1)] 
		[RED("equals")] 
		public CBool Equals_
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public workIWorkspotCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
