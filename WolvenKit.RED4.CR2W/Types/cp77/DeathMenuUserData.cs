using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeathMenuUserData : IScriptable
	{
		private CBool _playInitAnimation;

		[Ordinal(0)] 
		[RED("playInitAnimation")] 
		public CBool PlayInitAnimation
		{
			get
			{
				if (_playInitAnimation == null)
				{
					_playInitAnimation = (CBool) CR2WTypeManager.Create("Bool", "playInitAnimation", cr2w, this);
				}
				return _playInitAnimation;
			}
			set
			{
				if (_playInitAnimation == value)
				{
					return;
				}
				_playInitAnimation = value;
				PropertySet(this);
			}
		}

		public DeathMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
