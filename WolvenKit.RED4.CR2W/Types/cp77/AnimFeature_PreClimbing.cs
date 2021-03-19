using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PreClimbing : animAnimFeature
	{
		private Vector4 _edgePositionLS;
		private CFloat _valid;

		[Ordinal(0)] 
		[RED("edgePositionLS")] 
		public Vector4 EdgePositionLS
		{
			get => GetProperty(ref _edgePositionLS);
			set => SetProperty(ref _edgePositionLS, value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CFloat Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}

		public AnimFeature_PreClimbing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
