using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWaitTimeASTCD : audioAudioStateTransitionConditionData
	{
		private CFloat _timeToWait;

		[Ordinal(1)] 
		[RED("timeToWait")] 
		public CFloat TimeToWait
		{
			get
			{
				if (_timeToWait == null)
				{
					_timeToWait = (CFloat) CR2WTypeManager.Create("Float", "timeToWait", cr2w, this);
				}
				return _timeToWait;
			}
			set
			{
				if (_timeToWait == value)
				{
					return;
				}
				_timeToWait = value;
				PropertySet(this);
			}
		}

		public audioWaitTimeASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
