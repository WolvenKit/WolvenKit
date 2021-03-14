using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		private CBool _playerSafePass;
		private CBool _triggerExploded;

		[Ordinal(119)] 
		[RED("playerSafePass")] 
		public CBool PlayerSafePass
		{
			get
			{
				if (_playerSafePass == null)
				{
					_playerSafePass = (CBool) CR2WTypeManager.Create("Bool", "playerSafePass", cr2w, this);
				}
				return _playerSafePass;
			}
			set
			{
				if (_playerSafePass == value)
				{
					return;
				}
				_playerSafePass = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("triggerExploded")] 
		public CBool TriggerExploded
		{
			get
			{
				if (_triggerExploded == null)
				{
					_triggerExploded = (CBool) CR2WTypeManager.Create("Bool", "triggerExploded", cr2w, this);
				}
				return _triggerExploded;
			}
			set
			{
				if (_triggerExploded == value)
				{
					return;
				}
				_triggerExploded = value;
				PropertySet(this);
			}
		}

		public ExplosiveTriggerDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
