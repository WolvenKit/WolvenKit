using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallAction : redEvent
	{
		private CEnum<QuickSlotActionType> _calledAction;

		[Ordinal(0)] 
		[RED("calledAction")] 
		public CEnum<QuickSlotActionType> CalledAction
		{
			get => GetProperty(ref _calledAction);
			set => SetProperty(ref _calledAction, value);
		}

		public CallAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
