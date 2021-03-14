using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		private CFloat _timeToLive;

		[Ordinal(0)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get
			{
				if (_timeToLive == null)
				{
					_timeToLive = (CFloat) CR2WTypeManager.Create("Float", "timeToLive", cr2w, this);
				}
				return _timeToLive;
			}
			set
			{
				if (_timeToLive == value)
				{
					return;
				}
				_timeToLive = value;
				PropertySet(this);
			}
		}

		public gameEffectDuration_PredefinedTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
