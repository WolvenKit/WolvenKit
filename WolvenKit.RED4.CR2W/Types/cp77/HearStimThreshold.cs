using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HearStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _thresholdNumber;

		[Ordinal(0)] 
		[RED("thresholdNumber")] 
		public CInt32 ThresholdNumber
		{
			get
			{
				if (_thresholdNumber == null)
				{
					_thresholdNumber = (CInt32) CR2WTypeManager.Create("Int32", "thresholdNumber", cr2w, this);
				}
				return _thresholdNumber;
			}
			set
			{
				if (_thresholdNumber == value)
				{
					return;
				}
				_thresholdNumber = value;
				PropertySet(this);
			}
		}

		public HearStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
