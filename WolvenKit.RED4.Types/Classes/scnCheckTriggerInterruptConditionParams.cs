using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckTriggerInterruptConditionParams : RedBaseClass
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
	}
}
