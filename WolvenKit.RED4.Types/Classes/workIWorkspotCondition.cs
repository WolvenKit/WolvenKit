using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIWorkspotCondition : ISerializable
	{
		private CEnum<workWorkspotLogic> _expectedResult;
		private CBool _equals;

		[Ordinal(0)] 
		[RED("expectedResult")] 
		public CEnum<workWorkspotLogic> ExpectedResult
		{
			get => GetProperty(ref _expectedResult);
			set => SetProperty(ref _expectedResult, value);
		}

		[Ordinal(1)] 
		[RED("equals")] 
		public CBool Equals_
		{
			get => GetProperty(ref _equals);
			set => SetProperty(ref _equals, value);
		}
	}
}
