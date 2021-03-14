using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DelayEntry : animAnimFeature
	{
		private CBool _thresholdPassed;

		[Ordinal(0)] 
		[RED("thresholdPassed")] 
		public CBool ThresholdPassed
		{
			get
			{
				if (_thresholdPassed == null)
				{
					_thresholdPassed = (CBool) CR2WTypeManager.Create("Bool", "thresholdPassed", cr2w, this);
				}
				return _thresholdPassed;
			}
			set
			{
				if (_thresholdPassed == value)
				{
					return;
				}
				_thresholdPassed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DelayEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
