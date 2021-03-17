using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticPortalNode : worldNode
	{
		private CUInt8 _radius;
		private CUInt8 _nominalRadius;

		[Ordinal(4)] 
		[RED("radius")] 
		public CUInt8 Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(5)] 
		[RED("nominalRadius")] 
		public CUInt8 NominalRadius
		{
			get => GetProperty(ref _nominalRadius);
			set => SetProperty(ref _nominalRadius, value);
		}

		public worldAcousticPortalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
