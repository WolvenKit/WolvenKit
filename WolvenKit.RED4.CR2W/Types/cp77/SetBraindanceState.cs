using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBraindanceState : gameScriptableSystemRequest
	{
		private CBool _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CBool NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CBool) CR2WTypeManager.Create("Bool", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		public SetBraindanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
