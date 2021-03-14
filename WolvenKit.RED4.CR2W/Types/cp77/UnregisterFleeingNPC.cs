using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _runner;

		[Ordinal(0)] 
		[RED("runner")] 
		public wCHandle<entEntity> Runner
		{
			get
			{
				if (_runner == null)
				{
					_runner = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "runner", cr2w, this);
				}
				return _runner;
			}
			set
			{
				if (_runner == value)
				{
					return;
				}
				_runner = value;
				PropertySet(this);
			}
		}

		public UnregisterFleeingNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
