using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateWillingInvestigators : redEvent
	{
		private entEntityID _investigator;

		[Ordinal(0)] 
		[RED("investigator")] 
		public entEntityID Investigator
		{
			get
			{
				if (_investigator == null)
				{
					_investigator = (entEntityID) CR2WTypeManager.Create("entEntityID", "investigator", cr2w, this);
				}
				return _investigator;
			}
			set
			{
				if (_investigator == value)
				{
					return;
				}
				_investigator = value;
				PropertySet(this);
			}
		}

		public UpdateWillingInvestigators(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
