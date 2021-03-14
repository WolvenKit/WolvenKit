using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FocusMode : animAnimFeature
	{
		private CBool _isFocusModeActive;

		[Ordinal(0)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get
			{
				if (_isFocusModeActive == null)
				{
					_isFocusModeActive = (CBool) CR2WTypeManager.Create("Bool", "isFocusModeActive", cr2w, this);
				}
				return _isFocusModeActive;
			}
			set
			{
				if (_isFocusModeActive == value)
				{
					return;
				}
				_isFocusModeActive = value;
				PropertySet(this);
			}
		}

		public AnimFeature_FocusMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
