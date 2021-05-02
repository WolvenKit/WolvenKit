using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIPlacedComponent : entIComponent
	{
		private WorldTransform _localTransform;
		private CHandle<entITransformBinding> _parentTransform;

		[Ordinal(3)] 
		[RED("localTransform")] 
		public WorldTransform LocalTransform
		{
			get => GetProperty(ref _localTransform);
			set => SetProperty(ref _localTransform, value);
		}

		[Ordinal(4)] 
		[RED("parentTransform")] 
		public CHandle<entITransformBinding> ParentTransform
		{
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}

		public entIPlacedComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
