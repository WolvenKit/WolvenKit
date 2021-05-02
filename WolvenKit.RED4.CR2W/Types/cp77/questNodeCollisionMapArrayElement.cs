using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeCollisionMapArrayElement : CVariable
	{
		private NodeRef _objectRef;
		private CArray<questComponentCollisionMapArrayElement> _componentsCollisionMapArray;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("componentsCollisionMapArray")] 
		public CArray<questComponentCollisionMapArrayElement> ComponentsCollisionMapArray
		{
			get => GetProperty(ref _componentsCollisionMapArray);
			set => SetProperty(ref _componentsCollisionMapArray, value);
		}

		public questNodeCollisionMapArrayElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
