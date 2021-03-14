using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_TriggerModeChange : animAnimFeature
	{
		private CFloat _cycleTime;

		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get
			{
				if (_cycleTime == null)
				{
					_cycleTime = (CFloat) CR2WTypeManager.Create("Float", "cycleTime", cr2w, this);
				}
				return _cycleTime;
			}
			set
			{
				if (_cycleTime == value)
				{
					return;
				}
				_cycleTime = value;
				PropertySet(this);
			}
		}

		public AnimFeature_TriggerModeChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
