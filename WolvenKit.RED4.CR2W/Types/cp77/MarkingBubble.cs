using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarkingBubble : gameEffectExecutor_Scripted
	{
		private CFloat _delaySecondsPerMeterOfDistance;
		private CFloat _delayAdditionalRandomDelayMax;

		[Ordinal(1)] 
		[RED("delaySecondsPerMeterOfDistance")] 
		public CFloat DelaySecondsPerMeterOfDistance
		{
			get
			{
				if (_delaySecondsPerMeterOfDistance == null)
				{
					_delaySecondsPerMeterOfDistance = (CFloat) CR2WTypeManager.Create("Float", "delaySecondsPerMeterOfDistance", cr2w, this);
				}
				return _delaySecondsPerMeterOfDistance;
			}
			set
			{
				if (_delaySecondsPerMeterOfDistance == value)
				{
					return;
				}
				_delaySecondsPerMeterOfDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delayAdditionalRandomDelayMax")] 
		public CFloat DelayAdditionalRandomDelayMax
		{
			get
			{
				if (_delayAdditionalRandomDelayMax == null)
				{
					_delayAdditionalRandomDelayMax = (CFloat) CR2WTypeManager.Create("Float", "delayAdditionalRandomDelayMax", cr2w, this);
				}
				return _delayAdditionalRandomDelayMax;
			}
			set
			{
				if (_delayAdditionalRandomDelayMax == value)
				{
					return;
				}
				_delayAdditionalRandomDelayMax = value;
				PropertySet(this);
			}
		}

		public MarkingBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
