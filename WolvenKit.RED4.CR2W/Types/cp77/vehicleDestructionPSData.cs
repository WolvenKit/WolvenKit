using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDestructionPSData : CVariable
	{
		private CArrayFixedSize<CFloat> _gridValues;
		private CUInt32 _brokenGlass;
		private CUInt32 _brokenLights;
		private CUInt8 _flatTire;
		private CBool _windshieldShattered;
		private CArray<Vector3> _windshieldPoints;
		private CArray<CName> _detachedParts;

		[Ordinal(0)] 
		[RED("gridValues", 30)] 
		public CArrayFixedSize<CFloat> GridValues
		{
			get => GetProperty(ref _gridValues);
			set => SetProperty(ref _gridValues, value);
		}

		[Ordinal(1)] 
		[RED("brokenGlass")] 
		public CUInt32 BrokenGlass
		{
			get => GetProperty(ref _brokenGlass);
			set => SetProperty(ref _brokenGlass, value);
		}

		[Ordinal(2)] 
		[RED("brokenLights")] 
		public CUInt32 BrokenLights
		{
			get => GetProperty(ref _brokenLights);
			set => SetProperty(ref _brokenLights, value);
		}

		[Ordinal(3)] 
		[RED("flatTire")] 
		public CUInt8 FlatTire
		{
			get => GetProperty(ref _flatTire);
			set => SetProperty(ref _flatTire, value);
		}

		[Ordinal(4)] 
		[RED("windshieldShattered")] 
		public CBool WindshieldShattered
		{
			get => GetProperty(ref _windshieldShattered);
			set => SetProperty(ref _windshieldShattered, value);
		}

		[Ordinal(5)] 
		[RED("windshieldPoints")] 
		public CArray<Vector3> WindshieldPoints
		{
			get => GetProperty(ref _windshieldPoints);
			set => SetProperty(ref _windshieldPoints, value);
		}

		[Ordinal(6)] 
		[RED("detachedParts")] 
		public CArray<CName> DetachedParts
		{
			get => GetProperty(ref _detachedParts);
			set => SetProperty(ref _detachedParts, value);
		}

		public vehicleDestructionPSData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
