using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIWorkspotCondition : ISerializable
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

		public workIWorkspotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
