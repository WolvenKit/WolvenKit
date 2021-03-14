using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DistractionState : animAnimFeature
	{
		private CBool _isOn;

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

		public AnimFeature_DistractionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
