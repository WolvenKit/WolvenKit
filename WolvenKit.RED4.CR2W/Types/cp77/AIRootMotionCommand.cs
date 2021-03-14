using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRootMotionCommand : AIMoveCommand
	{
		private CHandle<gameSceneAnimationMotionActionParams> _params;

		[Ordinal(7)] 
		[RED("params")] 
		public CHandle<gameSceneAnimationMotionActionParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<gameSceneAnimationMotionActionParams>) CR2WTypeManager.Create("handle:gameSceneAnimationMotionActionParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public AIRootMotionCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
