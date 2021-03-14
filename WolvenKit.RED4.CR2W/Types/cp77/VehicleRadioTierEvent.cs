using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioTierEvent : redEvent
	{
		private CUInt32 _radioTier;
		private CBool _overrideTier;

		[Ordinal(0)] 
		[RED("radioTier")] 
		public CUInt32 RadioTier
		{
			get
			{
				if (_radioTier == null)
				{
					_radioTier = (CUInt32) CR2WTypeManager.Create("Uint32", "radioTier", cr2w, this);
				}
				return _radioTier;
			}
			set
			{
				if (_radioTier == value)
				{
					return;
				}
				_radioTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overrideTier")] 
		public CBool OverrideTier
		{
			get
			{
				if (_overrideTier == null)
				{
					_overrideTier = (CBool) CR2WTypeManager.Create("Bool", "overrideTier", cr2w, this);
				}
				return _overrideTier;
			}
			set
			{
				if (_overrideTier == value)
				{
					return;
				}
				_overrideTier = value;
				PropertySet(this);
			}
		}

		public VehicleRadioTierEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
