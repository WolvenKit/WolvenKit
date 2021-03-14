using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerHandicapSystem : gameScriptableSystem
	{
		private CBool _canDropHealingConsumable;
		private CBool _canDropAmmo;

		[Ordinal(0)] 
		[RED("canDropHealingConsumable")] 
		public CBool CanDropHealingConsumable
		{
			get
			{
				if (_canDropHealingConsumable == null)
				{
					_canDropHealingConsumable = (CBool) CR2WTypeManager.Create("Bool", "canDropHealingConsumable", cr2w, this);
				}
				return _canDropHealingConsumable;
			}
			set
			{
				if (_canDropHealingConsumable == value)
				{
					return;
				}
				_canDropHealingConsumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("canDropAmmo")] 
		public CBool CanDropAmmo
		{
			get
			{
				if (_canDropAmmo == null)
				{
					_canDropAmmo = (CBool) CR2WTypeManager.Create("Bool", "canDropAmmo", cr2w, this);
				}
				return _canDropAmmo;
			}
			set
			{
				if (_canDropAmmo == value)
				{
					return;
				}
				_canDropAmmo = value;
				PropertySet(this);
			}
		}

		public PlayerHandicapSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
