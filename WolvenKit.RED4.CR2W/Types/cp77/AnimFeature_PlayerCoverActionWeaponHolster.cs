using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerCoverActionWeaponHolster : animAnimFeature
	{
		private CBool _isWeaponHolstered;

		[Ordinal(0)] 
		[RED("isWeaponHolstered")] 
		public CBool IsWeaponHolstered
		{
			get
			{
				if (_isWeaponHolstered == null)
				{
					_isWeaponHolstered = (CBool) CR2WTypeManager.Create("Bool", "isWeaponHolstered", cr2w, this);
				}
				return _isWeaponHolstered;
			}
			set
			{
				if (_isWeaponHolstered == value)
				{
					return;
				}
				_isWeaponHolstered = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PlayerCoverActionWeaponHolster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
