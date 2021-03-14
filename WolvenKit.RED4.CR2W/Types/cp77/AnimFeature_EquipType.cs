using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_EquipType : animAnimFeature
	{
		private CBool _firstEquip;
		private CFloat _equipDuration;
		private CFloat _unequipDuration;

		[Ordinal(0)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get
			{
				if (_firstEquip == null)
				{
					_firstEquip = (CBool) CR2WTypeManager.Create("Bool", "firstEquip", cr2w, this);
				}
				return _firstEquip;
			}
			set
			{
				if (_firstEquip == value)
				{
					return;
				}
				_firstEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("equipDuration")] 
		public CFloat EquipDuration
		{
			get
			{
				if (_equipDuration == null)
				{
					_equipDuration = (CFloat) CR2WTypeManager.Create("Float", "equipDuration", cr2w, this);
				}
				return _equipDuration;
			}
			set
			{
				if (_equipDuration == value)
				{
					return;
				}
				_equipDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unequipDuration")] 
		public CFloat UnequipDuration
		{
			get
			{
				if (_unequipDuration == null)
				{
					_unequipDuration = (CFloat) CR2WTypeManager.Create("Float", "unequipDuration", cr2w, this);
				}
				return _unequipDuration;
			}
			set
			{
				if (_unequipDuration == value)
				{
					return;
				}
				_unequipDuration = value;
				PropertySet(this);
			}
		}

		public AnimFeature_EquipType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
