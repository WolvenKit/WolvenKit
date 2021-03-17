using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Plane : CVariable
	{
		private Vector4 _normalDistance;

		[Ordinal(0)] 
		[RED("NormalDistance")] 
		public Vector4 NormalDistance
		{
			get => GetProperty(ref _normalDistance);
			set => SetProperty(ref _normalDistance, value);
		}

		public Plane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
