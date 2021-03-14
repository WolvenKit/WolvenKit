using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetsUnconscious : questPuppetsEffector
	{
		private CBool _setUnconscious;

		[Ordinal(0)] 
		[RED("setUnconscious")] 
		public CBool SetUnconscious
		{
			get
			{
				if (_setUnconscious == null)
				{
					_setUnconscious = (CBool) CR2WTypeManager.Create("Bool", "setUnconscious", cr2w, this);
				}
				return _setUnconscious;
			}
			set
			{
				if (_setUnconscious == value)
				{
					return;
				}
				_setUnconscious = value;
				PropertySet(this);
			}
		}

		public questPuppetsUnconscious(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
