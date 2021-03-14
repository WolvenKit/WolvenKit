using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterNPCDodgeOpportunity : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _applyToTechWeapons;
		private CBool _doDodgingTargetsGetFilteredOut;

		[Ordinal(0)] 
		[RED("applyToTechWeapons")] 
		public CBool ApplyToTechWeapons
		{
			get
			{
				if (_applyToTechWeapons == null)
				{
					_applyToTechWeapons = (CBool) CR2WTypeManager.Create("Bool", "applyToTechWeapons", cr2w, this);
				}
				return _applyToTechWeapons;
			}
			set
			{
				if (_applyToTechWeapons == value)
				{
					return;
				}
				_applyToTechWeapons = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("doDodgingTargetsGetFilteredOut")] 
		public CBool DoDodgingTargetsGetFilteredOut
		{
			get
			{
				if (_doDodgingTargetsGetFilteredOut == null)
				{
					_doDodgingTargetsGetFilteredOut = (CBool) CR2WTypeManager.Create("Bool", "doDodgingTargetsGetFilteredOut", cr2w, this);
				}
				return _doDodgingTargetsGetFilteredOut;
			}
			set
			{
				if (_doDodgingTargetsGetFilteredOut == value)
				{
					return;
				}
				_doDodgingTargetsGetFilteredOut = value;
				PropertySet(this);
			}
		}

		public FilterNPCDodgeOpportunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
