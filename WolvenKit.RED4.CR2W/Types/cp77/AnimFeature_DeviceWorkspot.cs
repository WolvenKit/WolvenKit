using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DeviceWorkspot : animAnimFeature
	{
		private CBool _e3_lockInReferencePose;

		[Ordinal(0)] 
		[RED("e3_lockInReferencePose")] 
		public CBool E3_lockInReferencePose
		{
			get
			{
				if (_e3_lockInReferencePose == null)
				{
					_e3_lockInReferencePose = (CBool) CR2WTypeManager.Create("Bool", "e3_lockInReferencePose", cr2w, this);
				}
				return _e3_lockInReferencePose;
			}
			set
			{
				if (_e3_lockInReferencePose == value)
				{
					return;
				}
				_e3_lockInReferencePose = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DeviceWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
