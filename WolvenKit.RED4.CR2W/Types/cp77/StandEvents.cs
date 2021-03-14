using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StandEvents : LocomotionGroundEvents
	{
		private CFloat _previousStimTimeStamp;

		[Ordinal(0)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get
			{
				if (_previousStimTimeStamp == null)
				{
					_previousStimTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousStimTimeStamp", cr2w, this);
				}
				return _previousStimTimeStamp;
			}
			set
			{
				if (_previousStimTimeStamp == value)
				{
					return;
				}
				_previousStimTimeStamp = value;
				PropertySet(this);
			}
		}

		public StandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
