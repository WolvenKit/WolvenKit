using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AnimatedDevice : animAnimFeature
	{
		private CBool _isOn;
		private CBool _isOff;

		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get
			{
				if (_isOn == null)
				{
					_isOn = (CBool) CR2WTypeManager.Create("Bool", "isOn", cr2w, this);
				}
				return _isOn;
			}
			set
			{
				if (_isOn == value)
				{
					return;
				}
				_isOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isOff")] 
		public CBool IsOff
		{
			get
			{
				if (_isOff == null)
				{
					_isOff = (CBool) CR2WTypeManager.Create("Bool", "isOff", cr2w, this);
				}
				return _isOff;
			}
			set
			{
				if (_isOff == value)
				{
					return;
				}
				_isOff = value;
				PropertySet(this);
			}
		}

		public AnimFeature_AnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
