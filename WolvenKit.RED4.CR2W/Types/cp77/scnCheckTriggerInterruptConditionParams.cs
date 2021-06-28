using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckTriggerInterruptConditionParams : CVariable
	{
		private CBool _inside;
		private NodeRef _triggerArea;

		[Ordinal(0)] 
		[RED("inside")] 
		public CBool Inside
		{
			get => GetProperty(ref _inside);
			set => SetProperty(ref _inside, value);
		}

		[Ordinal(1)] 
		[RED("triggerArea")] 
		public NodeRef TriggerArea
		{
			get => GetProperty(ref _triggerArea);
			set => SetProperty(ref _triggerArea, value);
		}

		public scnCheckTriggerInterruptConditionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
