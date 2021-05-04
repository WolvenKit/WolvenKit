using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothExportedCapsule : CVariable
	{
		private Vector3 _p0;
		private Vector3 _p1;
		private CFloat _r0;
		private CFloat _r1;
		private CName _boneName;

		[Ordinal(0)] 
		[RED("p0")] 
		public Vector3 P0
		{
			get => GetProperty(ref _p0);
			set => SetProperty(ref _p0, value);
		}

		[Ordinal(1)] 
		[RED("p1")] 
		public Vector3 P1
		{
			get => GetProperty(ref _p1);
			set => SetProperty(ref _p1, value);
		}

		[Ordinal(2)] 
		[RED("r0")] 
		public CFloat R0
		{
			get => GetProperty(ref _r0);
			set => SetProperty(ref _r0, value);
		}

		[Ordinal(3)] 
		[RED("r1")] 
		public CFloat R1
		{
			get => GetProperty(ref _r1);
			set => SetProperty(ref _r1, value);
		}

		[Ordinal(4)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		public physicsclothExportedCapsule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
