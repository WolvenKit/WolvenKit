using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FriendlyTargetWeaponChangeCallback : gameAttachmentSlotsScriptCallback
	{
		private CHandle<AIFollowerRole> _followerRole;

		[Ordinal(2)] 
		[RED("followerRole")] 
		public CHandle<AIFollowerRole> FollowerRole
		{
			get
			{
				if (_followerRole == null)
				{
					_followerRole = (CHandle<AIFollowerRole>) CR2WTypeManager.Create("handle:AIFollowerRole", "followerRole", cr2w, this);
				}
				return _followerRole;
			}
			set
			{
				if (_followerRole == value)
				{
					return;
				}
				_followerRole = value;
				PropertySet(this);
			}
		}

		public FriendlyTargetWeaponChangeCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
