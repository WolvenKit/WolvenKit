using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUnequipItemParams : CVariable
	{
		private TweakDBID _slotId;
		private CFloat _unequipDurationOverride;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get
			{
				if (_unequipDurationOverride == null)
				{
					_unequipDurationOverride = (CFloat) CR2WTypeManager.Create("Float", "unequipDurationOverride", cr2w, this);
				}
				return _unequipDurationOverride;
			}
			set
			{
				if (_unequipDurationOverride == value)
				{
					return;
				}
				_unequipDurationOverride = value;
				PropertySet(this);
			}
		}

		public questUnequipItemParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
