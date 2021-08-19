using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Activator : InteractiveMasterDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CInt32 _hitCount;
		private CHandle<entMeshComponent> _meshComponent;
		private CName _meshAppearence;
		private CName _meshAppearenceBreaking;
		private CName _meshAppearenceBroken;
		private CFloat _defaultDelay;
		private CFloat _yellowDelay;
		private CFloat _redDelay;

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(98)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(99)] 
		[RED("meshComponent")] 
		public CHandle<entMeshComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(100)] 
		[RED("meshAppearence")] 
		public CName MeshAppearence
		{
			get => GetProperty(ref _meshAppearence);
			set => SetProperty(ref _meshAppearence, value);
		}

		[Ordinal(101)] 
		[RED("meshAppearenceBreaking")] 
		public CName MeshAppearenceBreaking
		{
			get => GetProperty(ref _meshAppearenceBreaking);
			set => SetProperty(ref _meshAppearenceBreaking, value);
		}

		[Ordinal(102)] 
		[RED("meshAppearenceBroken")] 
		public CName MeshAppearenceBroken
		{
			get => GetProperty(ref _meshAppearenceBroken);
			set => SetProperty(ref _meshAppearenceBroken, value);
		}

		[Ordinal(103)] 
		[RED("defaultDelay")] 
		public CFloat DefaultDelay
		{
			get => GetProperty(ref _defaultDelay);
			set => SetProperty(ref _defaultDelay, value);
		}

		[Ordinal(104)] 
		[RED("yellowDelay")] 
		public CFloat YellowDelay
		{
			get => GetProperty(ref _yellowDelay);
			set => SetProperty(ref _yellowDelay, value);
		}

		[Ordinal(105)] 
		[RED("redDelay")] 
		public CFloat RedDelay
		{
			get => GetProperty(ref _redDelay);
			set => SetProperty(ref _redDelay, value);
		}

		public Activator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
