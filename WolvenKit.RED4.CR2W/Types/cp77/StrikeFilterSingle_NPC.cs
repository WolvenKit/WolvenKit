using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _onlyAlive;

		[Ordinal(0)] 
		[RED("onlyAlive")] 
		public CBool OnlyAlive
		{
			get
			{
				if (_onlyAlive == null)
				{
					_onlyAlive = (CBool) CR2WTypeManager.Create("Bool", "onlyAlive", cr2w, this);
				}
				return _onlyAlive;
			}
			set
			{
				if (_onlyAlive == value)
				{
					return;
				}
				_onlyAlive = value;
				PropertySet(this);
			}
		}

		public StrikeFilterSingle_NPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
