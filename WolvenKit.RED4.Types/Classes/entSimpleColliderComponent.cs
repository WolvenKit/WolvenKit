using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entSimpleColliderComponent : entIPlacedComponent
	{
		private CBool _isEnabled;
		private CArray<CHandle<physicsICollider>> _colliders;
		private CHandle<physicsFilterData> _filter;
		private DataBuffer _compiledBuffer;

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(6)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetProperty(ref _colliders);
			set => SetProperty(ref _colliders, value);
		}

		[Ordinal(7)] 
		[RED("filter")] 
		public CHandle<physicsFilterData> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		[Ordinal(8)] 
		[RED("compiledBuffer")] 
		public DataBuffer CompiledBuffer
		{
			get => GetProperty(ref _compiledBuffer);
			set => SetProperty(ref _compiledBuffer, value);
		}

		public entSimpleColliderComponent()
		{
			_isEnabled = true;
		}
	}
}
