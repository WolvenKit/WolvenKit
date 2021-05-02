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
			get => GetProperty(ref _ikTargetsControllers);
			set => SetProperty(ref _ikTargetsControllers, value);
		}

		public animAnimNode_HumanIk(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
