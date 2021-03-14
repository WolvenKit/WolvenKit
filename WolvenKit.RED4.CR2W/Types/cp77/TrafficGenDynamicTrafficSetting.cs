using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficGenDynamicTrafficSetting : CVariable
	{
		private CEnum<TrafficGenDynamicImpact> _impact;

		[Ordinal(0)] 
		[RED("impact")] 
		public CEnum<TrafficGenDynamicImpact> Impact
		{
			get
			{
				if (_impact == null)
				{
					_impact = (CEnum<TrafficGenDynamicImpact>) CR2WTypeManager.Create("TrafficGenDynamicImpact", "impact", cr2w, this);
				}
				return _impact;
			}
			set
			{
				if (_impact == value)
				{
					return;
				}
				_impact = value;
				PropertySet(this);
			}
		}

		public TrafficGenDynamicTrafficSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
