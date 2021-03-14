using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionSceneInitData : IScriptable
	{
		private CInt32 _previousLocomotionState;

		[Ordinal(0)] 
		[RED("previousLocomotionState")] 
		public CInt32 PreviousLocomotionState
		{
			get
			{
				if (_previousLocomotionState == null)
				{
					_previousLocomotionState = (CInt32) CR2WTypeManager.Create("Int32", "previousLocomotionState", cr2w, this);
				}
				return _previousLocomotionState;
			}
			set
			{
				if (_previousLocomotionState == value)
				{
					return;
				}
				_previousLocomotionState = value;
				PropertySet(this);
			}
		}

		public LocomotionSceneInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
