using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneStateAnimationData : animAnimFeature
	{
		private CInt32 _statePose;

		[Ordinal(0)] 
		[RED("statePose")] 
		public CInt32 StatePose
		{
			get
			{
				if (_statePose == null)
				{
					_statePose = (CInt32) CR2WTypeManager.Create("Int32", "statePose", cr2w, this);
				}
				return _statePose;
			}
			set
			{
				if (_statePose == value)
				{
					return;
				}
				_statePose = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DroneStateAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
