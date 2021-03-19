using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCustomPersonalLinkReason : ScriptableDeviceAction
	{
		private TweakDBID _reason;

		[Ordinal(25)] 
		[RED("reason")] 
		public TweakDBID Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		public SetCustomPersonalLinkReason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
