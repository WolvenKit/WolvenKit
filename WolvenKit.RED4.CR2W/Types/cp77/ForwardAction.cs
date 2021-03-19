using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardAction : redEvent
	{
		private gamePersistentID _requester;
		private CHandle<ScriptableDeviceAction> _actionToForward;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get => GetProperty(ref _actionToForward);
			set => SetProperty(ref _actionToForward, value);
		}

		public ForwardAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
