using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDescriptionLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameRef;
		private CName _passedStateName;
		private CName _failedStateName;

		[Ordinal(1)] 
		[RED("NameRef")] 
		public inkTextWidgetReference NameRef
		{
			get => GetProperty(ref _nameRef);
			set => SetProperty(ref _nameRef, value);
		}

		[Ordinal(2)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get => GetProperty(ref _passedStateName);
			set => SetProperty(ref _passedStateName, value);
		}

		[Ordinal(3)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get => GetProperty(ref _failedStateName);
			set => SetProperty(ref _failedStateName, value);
		}

		public ScannerSkillCheckConditionDescriptionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
