using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InvestigateController : AIbehaviorconditionScript
	{
		private stimInvestigateData _investigateData;

		[Ordinal(0)] 
		[RED("investigateData")] 
		public stimInvestigateData InvestigateData
		{
			get
			{
				if (_investigateData == null)
				{
					_investigateData = (stimInvestigateData) CR2WTypeManager.Create("stimInvestigateData", "investigateData", cr2w, this);
				}
				return _investigateData;
			}
			set
			{
				if (_investigateData == value)
				{
					return;
				}
				_investigateData = value;
				PropertySet(this);
			}
		}

		public InvestigateController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
