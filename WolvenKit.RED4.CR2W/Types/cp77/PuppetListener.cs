using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetListener : IScriptable
	{
		private CHandle<gamePrereqState> _prereqOwner;

		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get
			{
				if (_prereqOwner == null)
				{
					_prereqOwner = (CHandle<gamePrereqState>) CR2WTypeManager.Create("handle:gamePrereqState", "prereqOwner", cr2w, this);
				}
				return _prereqOwner;
			}
			set
			{
				if (_prereqOwner == value)
				{
					return;
				}
				_prereqOwner = value;
				PropertySet(this);
			}
		}

		public PuppetListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
