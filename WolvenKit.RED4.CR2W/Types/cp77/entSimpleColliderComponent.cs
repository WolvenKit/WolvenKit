using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSimpleColliderComponent : entIPlacedComponent
	{
		private CArray<CHandle<physicsICollider>> _colliders;
		private CHandle<physicsFilterData> _filter;
		private DataBuffer _compiledBuffer;

		[Ordinal(5)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetProperty(ref _colliders);
			set => SetProperty(ref _colliders, value);
		}

		[Ordinal(6)] 
		[RED("filter")] 
		public CHandle<physicsFilterData> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		[Ordinal(7)] 
		[RED("compiledBuffer")] 
		public DataBuffer CompiledBuffer
		{
			get => GetProperty(ref _compiledBuffer);
			set => SetProperty(ref _compiledBuffer, value);
		}

		public entSimpleColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
