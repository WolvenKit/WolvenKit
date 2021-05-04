using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentCollarAreaParams : CVariable
	{
		private CBool _enable;
		private CFloat _radiusInCM;
		private CFloat _radiusForTriangleRemovalInCM;
		private CFloat _offsetFromSkinInCM;
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("radiusInCM")] 
		public CFloat RadiusInCM
		{
			get => GetProperty(ref _radiusInCM);
			set => SetProperty(ref _radiusInCM, value);
		}

		[Ordinal(2)] 
		[RED("radiusForTriangleRemovalInCM")] 
		public CFloat RadiusForTriangleRemovalInCM
		{
			get => GetProperty(ref _radiusForTriangleRemovalInCM);
			set => SetProperty(ref _radiusForTriangleRemovalInCM, value);
		}

		[Ordinal(3)] 
		[RED("offsetFromSkinInCM")] 
		public CFloat OffsetFromSkinInCM
		{
			get => GetProperty(ref _offsetFromSkinInCM);
			set => SetProperty(ref _offsetFromSkinInCM, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public garmentCollarAreaParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
