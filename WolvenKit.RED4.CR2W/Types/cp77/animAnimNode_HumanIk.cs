using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_HumanIk : animAnimNode_OnePoseInput
	{
		private CArray<animTEMP_IKTargetsControllerBodyType> _ikTargetsControllers;

		[Ordinal(12)] 
		[RED("ikTargetsControllers")] 
		public CArray<animTEMP_IKTargetsControllerBodyType> IkTargetsControllers
		{
			get
			{
				if (_ikTargetsControllers == null)
				{
					_ikTargetsControllers = (CArray<animTEMP_IKTargetsControllerBodyType>) CR2WTypeManager.Create("array:animTEMP_IKTargetsControllerBodyType", "ikTargetsControllers", cr2w, this);
				}
				return _ikTargetsControllers;
			}
			set
			{
				if (_ikTargetsControllers == value)
				{
					return;
				}
				_ikTargetsControllers = value;
				PropertySet(this);
			}
		}

		public animAnimNode_HumanIk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
