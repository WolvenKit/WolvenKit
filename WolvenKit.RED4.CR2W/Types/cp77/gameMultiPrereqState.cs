using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereqState : gamePrereqState
	{
		private CArray<CHandle<gamePrereqState>> _nestedStates;

		[Ordinal(0)] 
		[RED("nestedStates")] 
		public CArray<CHandle<gamePrereqState>> NestedStates
		{
			get
			{
				if (_nestedStates == null)
				{
					_nestedStates = (CArray<CHandle<gamePrereqState>>) CR2WTypeManager.Create("array:handle:gamePrereqState", "nestedStates", cr2w, this);
				}
				return _nestedStates;
			}
			set
			{
				if (_nestedStates == value)
				{
					return;
				}
				_nestedStates = value;
				PropertySet(this);
			}
		}

		public gameMultiPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
