using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegionPart : ISerializable
	{
		private Vector4 _innerRegion;
		private Vector4 _outerRegion;

		[Ordinal(0)] 
		[RED("innerRegion")] 
		public Vector4 InnerRegion
		{
			get => GetProperty(ref _innerRegion);
			set => SetProperty(ref _innerRegion, value);
		}

		[Ordinal(1)] 
		[RED("outerRegion")] 
		public Vector4 OuterRegion
		{
			get => GetProperty(ref _outerRegion);
			set => SetProperty(ref _outerRegion, value);
		}

		public rendTextureRegionPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
