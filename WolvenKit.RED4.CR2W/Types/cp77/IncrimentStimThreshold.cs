using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncrimentStimThreshold : AIbehaviortaskScript
	{
		private CFloat _thresholdTimeout;

		[Ordinal(0)] 
		[RED("thresholdTimeout")] 
		public CFloat ThresholdTimeout
		{
			get
			{
				if (_thresholdTimeout == null)
				{
					_thresholdTimeout = (CFloat) CR2WTypeManager.Create("Float", "thresholdTimeout", cr2w, this);
				}
				return _thresholdTimeout;
			}
			set
			{
				if (_thresholdTimeout == value)
				{
					return;
				}
				_thresholdTimeout = value;
				PropertySet(this);
			}
		}

		public IncrimentStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
