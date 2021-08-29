using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrespasserEntry : RedBaseClass
	{
		private CWeakHandle<gameObject> _trespasser;
		private CBool _isScanned;
		private CBool _isInsideA;
		private CBool _isInsideB;
		private CBool _isInsideScanner;
		private CArray<CName> _areaStack;

		[Ordinal(0)] 
		[RED("trespasser")] 
		public CWeakHandle<gameObject> Trespasser
		{
			get => GetProperty(ref _trespasser);
			set => SetProperty(ref _trespasser, value);
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		[Ordinal(2)] 
		[RED("isInsideA")] 
		public CBool IsInsideA
		{
			get => GetProperty(ref _isInsideA);
			set => SetProperty(ref _isInsideA, value);
		}

		[Ordinal(3)] 
		[RED("isInsideB")] 
		public CBool IsInsideB
		{
			get => GetProperty(ref _isInsideB);
			set => SetProperty(ref _isInsideB, value);
		}

		[Ordinal(4)] 
		[RED("isInsideScanner")] 
		public CBool IsInsideScanner
		{
			get => GetProperty(ref _isInsideScanner);
			set => SetProperty(ref _isInsideScanner, value);
		}

		[Ordinal(5)] 
		[RED("areaStack")] 
		public CArray<CName> AreaStack
		{
			get => GetProperty(ref _areaStack);
			set => SetProperty(ref _areaStack, value);
		}
	}
}
