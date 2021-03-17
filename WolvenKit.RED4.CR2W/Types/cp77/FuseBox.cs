using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseBox : InteractiveMasterDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CInt32 _numberOfComponentsToON;
		private CInt32 _numberOfComponentsToOFF;
		private CArray<CInt32> _indexesOfComponentsToOFF;
		private CHandle<entMeshComponent> _mesh;
		private CArray<CHandle<entIPlacedComponent>> _componentsON;
		private CArray<CHandle<entIPlacedComponent>> _componentsOFF;

		[Ordinal(93)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(94)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(95)] 
		[RED("numberOfComponentsToON")] 
		public CInt32 NumberOfComponentsToON
		{
			get => GetProperty(ref _numberOfComponentsToON);
			set => SetProperty(ref _numberOfComponentsToON, value);
		}

		[Ordinal(96)] 
		[RED("numberOfComponentsToOFF")] 
		public CInt32 NumberOfComponentsToOFF
		{
			get => GetProperty(ref _numberOfComponentsToOFF);
			set => SetProperty(ref _numberOfComponentsToOFF, value);
		}

		[Ordinal(97)] 
		[RED("indexesOfComponentsToOFF")] 
		public CArray<CInt32> IndexesOfComponentsToOFF
		{
			get => GetProperty(ref _indexesOfComponentsToOFF);
			set => SetProperty(ref _indexesOfComponentsToOFF, value);
		}

		[Ordinal(98)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(99)] 
		[RED("componentsON")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsON
		{
			get => GetProperty(ref _componentsON);
			set => SetProperty(ref _componentsON, value);
		}

		[Ordinal(100)] 
		[RED("componentsOFF")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsOFF
		{
			get => GetProperty(ref _componentsOFF);
			set => SetProperty(ref _componentsOFF, value);
		}

		public FuseBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
