using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPuppetBreachedPrereq : gameIScriptablePrereq
	{
		private CBool _isBreached;

		[Ordinal(0)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get
			{
				if (_isBreached == null)
				{
					_isBreached = (CBool) CR2WTypeManager.Create("Bool", "isBreached", cr2w, this);
				}
				return _isBreached;
			}
			set
			{
				if (_isBreached == value)
				{
					return;
				}
				_isBreached = value;
				PropertySet(this);
			}
		}

		public IsPuppetBreachedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
