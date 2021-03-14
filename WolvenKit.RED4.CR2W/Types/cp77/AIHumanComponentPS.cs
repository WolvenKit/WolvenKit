using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponentPS : AICommandQueuePS
	{
		private AISpotUsageToken _spotUsageToken;

		[Ordinal(2)] 
		[RED("spotUsageToken")] 
		public AISpotUsageToken SpotUsageToken
		{
			get
			{
				if (_spotUsageToken == null)
				{
					_spotUsageToken = (AISpotUsageToken) CR2WTypeManager.Create("AISpotUsageToken", "spotUsageToken", cr2w, this);
				}
				return _spotUsageToken;
			}
			set
			{
				if (_spotUsageToken == value)
				{
					return;
				}
				_spotUsageToken = value;
				PropertySet(this);
			}
		}

		public AIHumanComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
