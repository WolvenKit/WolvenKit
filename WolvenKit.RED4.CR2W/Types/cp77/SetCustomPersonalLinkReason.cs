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
			get
			{
				if (_reason == null)
				{
					_reason = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public SetCustomPersonalLinkReason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
