using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbstractLandEvents : LocomotionGroundEvents
	{
		private CBool _blockLandingStimBroadcasting;

		[Ordinal(0)] 
		[RED("blockLandingStimBroadcasting")] 
		public CBool BlockLandingStimBroadcasting
		{
			get
			{
				if (_blockLandingStimBroadcasting == null)
				{
					_blockLandingStimBroadcasting = (CBool) CR2WTypeManager.Create("Bool", "blockLandingStimBroadcasting", cr2w, this);
				}
				return _blockLandingStimBroadcasting;
			}
			set
			{
				if (_blockLandingStimBroadcasting == value)
				{
					return;
				}
				_blockLandingStimBroadcasting = value;
				PropertySet(this);
			}
		}

		public AbstractLandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
