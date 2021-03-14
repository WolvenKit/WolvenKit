using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUnequipCommand : AICommand
	{
		private TweakDBID _slotId;
		private CFloat _durationOverride;

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get
			{
				if (_durationOverride == null)
				{
					_durationOverride = (CFloat) CR2WTypeManager.Create("Float", "durationOverride", cr2w, this);
				}
				return _durationOverride;
			}
			set
			{
				if (_durationOverride == value)
				{
					return;
				}
				_durationOverride = value;
				PropertySet(this);
			}
		}

		public AIUnequipCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
