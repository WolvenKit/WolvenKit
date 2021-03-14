using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DisableSleepMode : animAnimNode_OnePoseInput
	{
		private CBool _forceUpdate;

		[Ordinal(12)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get
			{
				if (_forceUpdate == null)
				{
					_forceUpdate = (CBool) CR2WTypeManager.Create("Bool", "forceUpdate", cr2w, this);
				}
				return _forceUpdate;
			}
			set
			{
				if (_forceUpdate == value)
				{
					return;
				}
				_forceUpdate = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DisableSleepMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
